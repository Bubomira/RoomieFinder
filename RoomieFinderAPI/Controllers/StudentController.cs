using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RoomieFinderCore.Contracts.RoomContracts;
using RoomieFinderCore.Contracts.StudentContracts;
using RoomieFinderCore.Dtos.StudentDtos;

namespace RoomieFinderAPI.Controllers
{
    [ApiController]
    [Route("student")]
    [Authorize(Roles = "GreatAdmin", AuthenticationSchemes = "Bearer")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentContract _studentContract;
        private readonly IRoomContract _roomContract;
        public StudentController(IStudentContract studentContract,
            IRoomContract roomContract)
        {
            _studentContract = studentContract;
            _roomContract = roomContract;
        }

        [HttpGet("without/rooms")]
        [ProducesResponseType(400)]
        [ProducesResponseType(200, Type = typeof(RoomlessStudentsListDto))]
        public async Task<IActionResult> GetAllStudentsWithoutARoom([FromQuery] int pageNumber)
        {
            RoomlessStudentsListDto roomlessStudentsListDto = new RoomlessStudentsListDto() { PageNumber = pageNumber };

            await _roomContract.GetAllStudentsWithoutARoomAsync(roomlessStudentsListDto);

            if (roomlessStudentsListDto.StudentsWithoutARoom.Count == 0)
            {
                return BadRequest();
            }

            return Ok(roomlessStudentsListDto);
        }

        [HttpGet("{userId}/matches")]
        [ProducesResponseType(404)]
        [ProducesResponseType(200, Type = typeof(List<StudentBestMatchDto>))]
        public async Task<IActionResult> GetTopThreeBestMatches(string userId)
        {
            if (await _studentContract.CheckIfStudentExistsByUserIdAsync(userId))
            {
                bool isMale = await _studentContract.CheckIfStudentIsMaleAsync(userId);
                var list = await _studentContract.GetTopThreeRoomateMatchesForAStudentAsync(userId, isMale);

                return Ok(list);
            }
            return NotFound();
        }
    }
}
