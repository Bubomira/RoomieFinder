using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RoomieFinderCore.Contracts.RoomContracts;

namespace RoomieFinderAPI.Controllers
{
    [ApiController]
    [Route("room")]
    [Authorize(Roles = "GreatAdmin", AuthenticationSchemes = "Bearer")]
    public class RoomController : ControllerBase
    {
        private readonly IRoomCheckerContract _roomCheckerContract;
        private readonly IRoomContract _roomContract;

        public RoomController(IRoomCheckerContract roomCheckerContract,
            IRoomContract roomContract)
        {
            _roomCheckerContract = roomCheckerContract;
            _roomContract = roomContract;
        }

        [HttpGet("{roomId}/add/student/{userId}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> AddStudentToRoom(int roomId, string userId)
        {
            if (await _roomCheckerContract.CheckIfRoomExistsByIdAsync(roomId))
            {
                if (!await _roomCheckerContract.CheckIfStudentIsAlreadyAsignedToTheSpecifiedRoomAsync(userId, roomId)
                    && await _roomCheckerContract.CheckIfRoomHasCapacityAsync(roomId))
                {
                    await _roomContract.AsignRoomToStudentAsync(userId, roomId);
                    return NoContent();
                }
                return BadRequest();
            }

            return NotFound();
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
