

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
    }
}
