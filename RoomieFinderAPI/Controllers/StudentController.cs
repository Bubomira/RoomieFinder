using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RoomieFinderCore.Contracts.RoomContracts;
using RoomieFinderCore.Contracts.StudentContracts;
using RoomieFinderCore.Dtos.StudentDtos;
using System.Security.Claims;

namespace RoomieFinderAPI.Controllers
{
    [ApiController]
    [Route("student")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentContract _studentContract;
        private readonly IStudentCheckerContract _studentCheckerContract;
        private readonly IRoomContract _roomContract;
        public StudentController(IStudentContract studentContract,
            IStudentCheckerContract studentCheckerContract,
            IRoomContract roomContract)
        {
            _studentContract = studentContract;
            _studentCheckerContract = studentCheckerContract;
            _roomContract = roomContract;
        }

        [HttpGet("without/rooms")]
        [ProducesResponseType(400)]
        [ProducesResponseType(200, Type = typeof(RoomlessStudentsListDto))]
        [Authorize(Roles = "GreatAdmin", AuthenticationSchemes = "Bearer")]
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
        [Authorize(Roles = "GreatAdmin", AuthenticationSchemes = "Bearer")]
        public async Task<IActionResult> GetTopThreeBestMatches(string userId)
        {
            if (await _studentCheckerContract.CheckIfStudentExistsByUserIdAsync(userId))
            {
                bool isMale = await _studentCheckerContract.CheckIfStudentIsMaleAsync(userId);
                var list = await _studentContract.GetTopThreeRoomateMatchesForAStudentAsync(userId, isMale);

                return Ok(list);
            }
            return NotFound();
        }

        [HttpGet("profile/{userId}")]
        [ProducesResponseType(404)]
        [ProducesResponseType(400)]
        [ProducesResponseType(200, Type = typeof(StudentProfileDto))]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public async Task<IActionResult> GetStudentProfile(string userId)
        {
            if (User.IsInRole("Student") && userId != User.Id())
            {
                return BadRequest();
            }
            if (await _studentCheckerContract.CheckIfStudentExistsByUserIdAsync(userId))
            {
                return Ok(await _studentContract.GetStudentProfile(userId));
            }
            return NotFound();
        }
    }
}
