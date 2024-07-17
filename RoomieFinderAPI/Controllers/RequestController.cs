using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RoomieFinderCore.Contracts.RequestContracts;
using RoomieFinderCore.Dtos.RequestDtos;

namespace RoomieFinderAPI.Controllers
{
    [ApiController]
    [Route("request")]
    public class RequestController : ControllerBase
    {
        private readonly IRequestContract _requestContract;
        private readonly IRequestCheckerContract _requestCheckerContract;
        private readonly IRequestStatusContract _requestStatusContract;

        public RequestController(IRequestContract requestContract,
            IRequestCheckerContract requestCheckerContract,
            IRequestStatusContract requestStatusContract)
        {
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
        [Authorize(Roles = "GreatAdmin", AuthenticationSchemes = "Bearer")]
        public async Task<IActionResult> GetRequestDetails(int requestId)
        {
            if (await _requestCheckerContract.CheckIfRequestExistsByIdAsync(requestId))
            {
                var request = await _requestContract.GetRequestDetailsAsync(requestId);
                return Ok(request);
            }
            return NotFound();
        }
    }
}
