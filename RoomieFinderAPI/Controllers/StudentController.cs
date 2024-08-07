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
        private readonly IRoomateMatchingContract _roommateMatchingContract;
        private readonly IRoomContract _roomContract;
        public StudentController(IStudentContract studentContract,
            IStudentCheckerContract studentCheckerContract,
            IRoomateMatchingContract roomateMatchingContract,
            IRoomContract roomContract)
        {
            _studentContract = studentContract;
            _studentCheckerContract = studentCheckerContract;
            _roommateMatchingContract = roomateMatchingContract;
            _roomContract = roomContract;
        }

        [HttpGet("all")]
        [ProducesResponseType(400)]
        [ProducesResponseType(200, Type = typeof(StudentListDto))]
        [Authorize(Roles = "GreatAdmin", AuthenticationSchemes = "Bearer")]
        public async Task<IActionResult> GetAllStudents([FromQuery] StudentSeachListDto studentSeachListDto)
        {
            await _studentContract.GetAllStudents(studentSeachListDto);

            if (studentSeachListDto.Students.Count == 0 && studentSeachListDto.PageNumber!=1
                && studentSeachListDto.PageNumber*StudentListDto.StudentsOnPage>studentSeachListDto.TotalCount)
            {
                return BadRequest();
            }

            return Ok(studentSeachListDto);
        }

        [HttpGet("without/rooms")]
        [ProducesResponseType(400)]
        [ProducesResponseType(200, Type = typeof(StudentListDto))]
        [Authorize(Roles = "GreatAdmin", AuthenticationSchemes = "Bearer")]
        public async Task<IActionResult> GetAllStudentsWithoutARoom([FromQuery] int pageNumber)
        {
            StudentListDto roomlessStudentsListDto = new StudentListDto() { PageNumber = pageNumber };

            await _roomContract.GetAllStudentsWithoutARoomAsync(roomlessStudentsListDto);

            if (roomlessStudentsListDto.Students.Count == 0 && roomlessStudentsListDto.PageNumber != 1
                && roomlessStudentsListDto.PageNumber * StudentListDto.StudentsOnPage > roomlessStudentsListDto.TotalCount)
            {
                return BadRequest();
            }

            return Ok(roomlessStudentsListDto);
        }

        [HttpGet("{userId}/matches")]
        [ProducesResponseType(404)]
        [ProducesResponseType(400)]
        [ProducesResponseType(200, Type = typeof(RoomateMatchesListDto))]
        [Authorize(Roles = "GreatAdmin", AuthenticationSchemes = "Bearer")]
        public async Task<IActionResult> GetRoomateMatches([FromQuery] int pageNumber, string userId)
        {
            RoomateMatchesListDto roomateMatchesListDto = new RoomateMatchesListDto(pageNumber,userId);
            if (await _studentCheckerContract.CheckIfStudentExistsByUserIdAsync(userId))
            {
                roomateMatchesListDto.IsMale = await _studentCheckerContract.CheckIfStudentIsMaleAsync(userId);
                await _roommateMatchingContract.GetRoomateMatchesForAStudentAsync(userId, roomateMatchesListDto);

                if (roomateMatchesListDto.BestMatches.Count == 0 && pageNumber!=1)
                {
                    return BadRequest();
                }

                return Ok(roomateMatchesListDto);
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
