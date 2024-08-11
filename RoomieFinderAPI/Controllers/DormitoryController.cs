using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RoomieFinderCore.Contracts.DormitotyContracts;
using RoomieFinderCore.Dtos.DormitoryDtos;
using RoomieFinderCore.Dtos.RoomDtos;

namespace RoomieFinderAPI.Controllers
{
    [ApiController]
    [Route("dormitory")]
    [Authorize(Roles = "GreatAdmin", AuthenticationSchemes = "Bearer")]
    public class DormitoryController : ControllerBase
    {
        private readonly IDormitoryContract _dormitoryContract;

        public DormitoryController(IDormitoryContract dormitoryContract)
        {
            _dormitoryContract = dormitoryContract;
        }

        [HttpGet("all")]
        [ProducesResponseType(200, Type = typeof(List<DormitoryPreviewDto>))]
        public async Task<IActionResult> GetAllDormitories() =>
            Ok(await _dormitoryContract.GetAllDormitoriesAsync());

        [HttpGet("{dormitoryId}/rooms")]
        [ProducesResponseType(404)]
        [ProducesResponseType(200, Type = typeof(List<RoomDetailsDto>))]
        public async Task<IActionResult> GetAllRoomsFromADormitory(int dormitoryId, [FromQuery]bool isMale)
        {
            if (await _dormitoryContract.CheckIfDormitoryExistsByIdAsync(dormitoryId))
            {
                return Ok(await _dormitoryContract.GetAllRoomsFromADormitoryByIdAsync(dormitoryId,isMale));
            }
            return NotFound();
        }

        [HttpGet("{dormitoryId}/rooms/single")]
        [ProducesResponseType(200, Type = typeof(List<RoomDetailsDto>))]
        public async Task<IActionResult> GetAllSingleRoomsFromADormitory(int dormitoryId, [FromQuery] bool isMale)
        {
            if (await _dormitoryContract.CheckIfDormitoryExistsByIdAsync(dormitoryId))
            {
                return Ok(await _dormitoryContract.GetAllSingleRoomsFromADormitoryByIdAsync(dormitoryId));
            }
            return NotFound();
        }

    }
}
