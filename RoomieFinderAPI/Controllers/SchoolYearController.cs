using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RoomieFinderCore.Contracts.RoomContracts;
using RoomieFinderCore.Contracts.StudentContracts;

namespace RoomieFinderAPI.Controllers
{
    [ApiController]
    [Route("school/year")]
    [Authorize(Roles = "GreatAdmin", AuthenticationSchemes = "Bearer")]
    public class SchoolYearController : ControllerBase
    {
        private readonly IStudentContract _studentContract;
        private readonly IRoomContract _roomContract;
        public SchoolYearController(IStudentContract studentContract,
            IRoomContract roomContract)
        {
            _studentContract = studentContract;
            _roomContract = roomContract;
        }

        [HttpGet("end")]
        [ProducesResponseType(204)]
        public async Task<IActionResult> EndSchoolYear()
        {
            await _studentContract.MoveUngraduatedStudentsToNextYearAsync();
            await _studentContract.GraduateStudentsAsync();

            await _roomContract.RemoveRecentlyGraduatedStudentsFromRoomsAsync();

            return NoContent();
        }
    }
}
