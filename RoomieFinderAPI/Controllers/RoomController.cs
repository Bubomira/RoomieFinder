using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RoomieFinderCore.Contracts.RoomContracts;
using RoomieFinderCore.Contracts.StudentContracts;

namespace RoomieFinderAPI.Controllers
{
    [ApiController]
    [Route("room")]
    [Authorize(Roles = "GreatAdmin", AuthenticationSchemes = "Bearer")]
    public class RoomController : ControllerBase
    {
        private readonly IStudentCheckerContract _studentCheckerContract;
        private readonly IRoomCheckerContract _roomCheckerContract;
        private readonly IStudentContract _studentContract;
        private readonly IRoomContract _roomContract;

        public RoomController(IRoomCheckerContract roomCheckerContract,
            IStudentContract studentContract,
            IRoomContract roomContract,
            IStudentCheckerContract studentCheckerContract)
        {
            _roomCheckerContract = roomCheckerContract;
            _studentCheckerContract = studentCheckerContract;
            _studentContract = studentContract;
            _roomContract = roomContract;
        }

        [HttpGet("{roomId}/add/student/{userId}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> AddStudentToRoom(int roomId, string userId)
        {
            if (await _roomCheckerContract.CheckIfRoomExistsByIdAsync(roomId) && await _studentCheckerContract.CheckIfStudentExistsByUserIdAsync(userId))
            {
                if (!await _roomCheckerContract.CheckIfStudentIsAlreadyAsignedToTheSpecifiedRoomAsync(userId, roomId)
                    && await _roomCheckerContract.CheckIfRoomHasCapacityAsync(roomId))
                {
                    bool isMale = await _studentCheckerContract.CheckIfStudentIsMaleAsync(userId);
                    if (await _roomCheckerContract.CheckIfStudentCanBeAssignedToRoomByGenderAsync(roomId,isMale))
                    {
                        await _roomContract.AsignRoomToStudentAsync(userId, roomId);
                        return NoContent(); 
                    }
                }
                return BadRequest();
            }

            return NotFound();
        }

        [HttpGet("{roomId}/add/student/by/email/{studentEmail}")]
        [ProducesResponseType(400)]
        public async Task<IActionResult> AddStudentToRoomByEmail(int roomId, string studentEmail)
        {
            var userId = await _studentContract.GetUserIdByEmailAsync(studentEmail);
            if (string.IsNullOrEmpty(userId))
            {
                return BadRequest();
            };

            return RedirectToAction(nameof(AddStudentToRoom), new { roomId = roomId, userId = userId });
        }

        [HttpDelete("{roomId}/remove/student/{userId}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        public async Task<IActionResult> RemoveStudentFromRoom(int roomId, string userId)
        {
            if (await _roomCheckerContract.CheckIfStudentIsAlreadyAsignedToTheSpecifiedRoomAsync(userId, roomId)
                && await _roomCheckerContract.CheckIfThereIsACapacityInOtherRoomsAsync(roomId))
            {
                await _roomContract.RemoveStudentFromARoomAsync(userId);
                return NoContent();
            }

            return BadRequest();
        }
    }
}
