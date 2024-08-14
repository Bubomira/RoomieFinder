using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RoomieFinderCore.Contracts.RequestContracts;
using RoomieFinderCore.Contracts.StudentContracts;
using RoomieFinderCore.Dtos.RequestDtos;
using RoomieFinderInfrastructure.Enums;
using System.Security.Claims;

namespace RoomieFinderAPI.Controllers
{
    [ApiController]
    [Route("request")]
    public class RequestController : ControllerBase
    {
        private readonly IRequestContract _requestContract;
        private readonly IRequestCheckerContract _requestCheckerContract;
        private readonly IRequestStatusContract _requestStatusContract;
        private readonly IStudentCheckerContract _studentCheckerContract;
        private readonly IStudentContract _studentContract;

        public RequestController(IRequestContract requestContract,
            IRequestCheckerContract requestCheckerContract,
            IRequestStatusContract requestStatusContract,
            IStudentCheckerContract studentCheckerContract,
            IStudentContract studentContract)
        {
            _studentContract = studentContract;
            _studentCheckerContract = studentCheckerContract;
            _requestContract = requestContract;
            _requestCheckerContract = requestCheckerContract;
            _requestStatusContract = requestStatusContract;
        }

        [HttpGet("all")]
        [ProducesResponseType(400)]
        [ProducesResponseType(200, Type = typeof(RequestListDto))]
        [Authorize(Roles = "GreatAdmin", AuthenticationSchemes = "Bearer")]
        public async Task<IActionResult> GetAllRequests([FromQuery] RequestListDto requestListDto)
        {
            await _requestContract.GetAllRequestsAsync(requestListDto);

            if (requestListDto.Requests.Count == 0 && requestListDto.CurrentPage!=1)
            {
                return BadRequest();
            }

            return Ok(requestListDto);
        }


        [HttpGet("details/{requestId}")]
        [ProducesResponseType(404)]
        [ProducesResponseType(200, Type = typeof(RequestDetailsDto))]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public async Task<IActionResult> GetRequestDetails(int requestId)
        {
            if (await _requestCheckerContract.CheckIfRequestExistsByIdAsync(requestId))
            {
                if (!User.IsInRole("GreatAdmin")
                    && !await _requestCheckerContract.ChecksIfRequestIsSubmittedByUserAsync(requestId, User.Id() ?? ""))
                {
                    return Forbid();
                }

                bool isMale = await _requestCheckerContract.CheckIfStudentIsMaleByRequestIdAsync(requestId);
               
                return Ok(await _requestContract.GetRequestDetailsAsync(requestId, isMale));
            }
            return NotFound();
        }


        [HttpGet("possible/types")]
        [ProducesResponseType(200, Type = typeof(List<RequestType>))]
        [Authorize(Roles = "Student", AuthenticationSchemes = "Bearer")]
        public async Task<IActionResult> GetPossibleRequestTypeForStudent() =>
             Ok(await _requestStatusContract.GetPossibleRequestTypesAsync(User.Id() ?? ""));


        [HttpPost("submit")]
        [ProducesResponseType(400)]
        [ProducesResponseType(201)]
        [Authorize(Roles = "Student", AuthenticationSchemes = "Bearer")]
        public async Task<IActionResult> SubmitRequest([FromBody] RequestPostDto requestPostDto)
        {
            if (ModelState.IsValid
                && !await _requestCheckerContract.CheckIfThereIsAnotherUnArchivedRequestOfTypeForUserAsync(User.Id() ?? "",requestPostDto.RequestType))
            {
                if (requestPostDto.RequestType == RequestType.SpecificRoomate
                    && (!await _studentCheckerContract.CheckIfStudentExistsByEmailAsync(requestPostDto.Comment) ||
                        await _studentCheckerContract.CheckIfEmailBelongsToCurrentUserByIdAsync(User.Id() ?? "", requestPostDto.Comment)))
                {
                    return BadRequest();
                }

                var studentId = await _studentContract.GetStudentIdAsync(User.Id() ?? "");
                await _requestContract.SubmitRequestAsync(requestPostDto, studentId);

                return Created();
            }
            return BadRequest();
        }

        [HttpGet("remove/{requestId}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [Authorize(Roles = "Student", AuthenticationSchemes = "Bearer")]
        public async Task<IActionResult> RemoveRequest(int requestId)
        {
            if (await _requestCheckerContract.ChecksIfTheRequestIsSubmittedByUserAndPendingAsync(requestId, User.Id() ?? ""))
            {
                await _requestContract.RemoveRequestAsync(requestId);

                return NoContent();
            }
            return BadRequest();
        }

        [HttpGet("accept/{requestId}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(200,Type =typeof(string))]
        [Authorize(Roles = "GreatAdmin", AuthenticationSchemes = "Bearer")]
        public async Task<IActionResult> AcceptRequest(int requestId)
        {
            if (await _requestCheckerContract.CheckIfRequestExistsByIdAsync(requestId))
            {
                if (await _requestCheckerContract.CheckIfRequestIsOfTypeAsync(requestId, RequestType.SpecificRoomate)) 
                {
                    var specificRoomateEmail = await _requestContract.GetSpecificRoomateEmailByRequestId(requestId);
                    if (string.IsNullOrEmpty(specificRoomateEmail) 
                        || !await _studentCheckerContract.CheckIfStudentExistsByEmailAsync(specificRoomateEmail))
                    {
                        return BadRequest();
                    }
                    await _requestStatusContract.ChangeRequestStatusAsync(requestId, RequestStatus.Accepted);
                    return Ok(new {specificUserId= await _studentContract.GetUserIdByEmailAsync(specificRoomateEmail)});
                }
                await _requestStatusContract.ChangeRequestStatusAsync(requestId, RequestStatus.Accepted);
                return NoContent();
            }

            return BadRequest();
        }


        [HttpGet("decline/{requestId}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [Authorize(Roles = "GreatAdmin", AuthenticationSchemes = "Bearer")]
        public async Task<IActionResult> DeclineRequest(int requestId)
        {
            if (await _requestCheckerContract.CheckIfRequestExistsByIdAsync(requestId))
            {
                await _requestStatusContract.ChangeRequestStatusAsync(requestId, RequestStatus.Declined);
                return NoContent();
            }

            return BadRequest();
        }
    }
}
