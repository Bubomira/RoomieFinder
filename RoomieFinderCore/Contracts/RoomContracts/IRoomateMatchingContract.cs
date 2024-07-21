using RoomieFinderCore.Dtos.StudentDtos;

namespace RoomieFinderCore.Contracts.RoomContracts
{
    public interface IRoomateMatchingContract
    {
        /// <summary>
        /// Calculates roommate mathes for a student based on initial reuirements and the answers the student has provided
        /// </summary>
        /// <param name="studentId"></param>
        /// <returns></returns>
        public Task GetRoomateMatchesForAStudentAsync(string userId, RoomateMatchesListDto roomateMatchesListDto);
    }
}
