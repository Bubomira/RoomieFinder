using Microsoft.EntityFrameworkCore;
using RoomieFinderCore.Contracts.StudentContracts;
using RoomieFinderInfrastructure.Models;
using RoomieFinderInfrastructure.UnitOfWork;

namespace RoomieFinderCore.Services.StudentServices
{
    public class StudentCheckerService : IStudentCheckerContract
    {
        private readonly IUnitOfWork _unitOfWork;

        public StudentCheckerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<bool> CheckIfStudentIsMaleAsync(string userId) =>
             _unitOfWork.GetAllAsReadOnlyAsync<Student>()
             .Where(s => s.ApplicationUserId == userId)
             .Select(s => s.IsMale)
             .FirstOrDefaultAsync();
        public Task<bool> CheckIfStudentExistsByUserIdAsync(string userId) =>
            _unitOfWork.GetAllAsReadOnlyAsync<Student>()
            .AnyAsync(s => s.ApplicationUserId == userId);

        public Task<bool> CheckIfStudentExistsByEmailAsync(string email) =>
            _unitOfWork.GetAllAsReadOnlyAsync<Student>()
            .AnyAsync(s => s.ApplicationUser.Email == email);
    }
}
