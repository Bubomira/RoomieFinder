

using RoomieFinderCore.Dtos.StudentDtos;

namespace RoomieFinderCore.Contracts.StudentContracts
{
    public interface IStudentContract
    {
        /// <summary>
        /// Get coresponding student id by the users id
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public Task<int> GetStudentIdAsync(string userId);

        /// <summary>
        /// Checks if the student's gender is male
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public Task<bool> CheckIfStudentIsMaleAsync(string userId);

        /// <summary>
        /// Checks if the student exists by their user id
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public Task<bool> CheckIfStudentExistsByUserIdAsync(string userId);

        /// <summary>
        /// Gets the top three best mathes for a student based on initial reuirements and the answers the student has provided
        /// </summary>
        /// <param name="studentId"></param>
        /// <returns></returns>
        public Task<List<StudentBestMatchDto>> GetTopThreeRoomateMatchesForAStudentAsync(string userId, bool isMale);

        /// <summary>
        /// Moves undergraduate students to next year
        /// </summary>
        /// <returns></returns>
        public Task MoveUngraduatedStudentsToNextYearAsync();
        /// <summary>
        /// Graduates students who have reached the year 4
        /// </summary>
        /// <returns></returns>
        public Task GraduateStudentsAsync();

    }
}
