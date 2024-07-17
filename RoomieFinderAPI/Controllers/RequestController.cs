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
        public async Task<IActionResult> GetAllRequests([FromQuery] int pageNumber)
        {
            RequestListDto requestListDto = new RequestListDto() { CurrentPage = pageNumber };

            await _requestContract.GetAllRequestsAsync(requestListDto);

            if (requestListDto.Requests.Count == 0)
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
                var request = await _requestContract.GetRequestDetailsAsync(requestId);
                return Ok(request);
            }
            return NotFound();
        }

        [HttpPost("submit")]
        [ProducesResponseType(400)]
        [Authorize(Roles = "Student", AuthenticationSchemes = "Bearer")]
        public async Task<IActionResult> SubmitRequest([FromBody] RequestPostDto requestPostDto)
        {
            if (ModelState.IsValid
                && !await _requestCheckerContract.CheckIfThereIsAnotherUnArchivedRequestForUserAsync(User.Id() ?? ""))
            {
                if (requestPostDto.RequestType == RequestType.SpecificRoomate && !await _studentCheckerContract.CheckIfStudentExistsByEmailAsync(requestPostDto.Comment))
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
    }
}
