

namespace RoomieFinderCore.Contracts.StudentContracts
{
    public interface IStudentCheckerContract
    {
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
        /// Checks if a student exists based of email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public Task<bool> CheckIfStudentExistsByEmailAsync(string email);
    }
}
