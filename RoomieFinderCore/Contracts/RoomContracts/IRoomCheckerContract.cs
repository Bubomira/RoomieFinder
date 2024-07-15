namespace RoomieFinderCore.Contracts.RoomContracts
{
    public interface IRoomCheckerContract
    {
        /// <summary>
        /// Checks whether a room exists by id
        /// </summary>
        /// <param name="roomId"></param>
        /// <returns></returns>
        public Task<bool> CheckIfRoomExistsByIdAsync(int roomId);

        /// <summary>
        /// Checks if a room has any capacity left
        /// </summary>
        /// <param name="roomId"></param>
        /// <returns></returns>

        public Task<bool> CheckIfRoomHasCapacityAsync(int roomId);

        /// <summary>
        /// Checks whether a student has been asigned to a particular room
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="roomId"></param>
        /// <returns></returns>
        public Task<bool> CheckIfStudentIsAlreadyAsignedToTheSpecifiedRoomAsync(string userId, int roomId);
    }
}
