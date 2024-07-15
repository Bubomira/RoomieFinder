

using Microsoft.EntityFrameworkCore;
using RoomieFinderCore.Contracts.RoomContracts;
using RoomieFinderCore.Dtos.StudentDtos;
using RoomieFinderInfrastructure.Models;
using RoomieFinderInfrastructure.UnitOfWork;

namespace RoomieFinderCore.Services.RoomServices
{
    public class RoomService : IRoomContract
    {
        private readonly IUnitOfWork _unitOfWork;
        public RoomService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task AsignRoomToStudentAsync(string userId, int roomId)
        {
            await _unitOfWork.GetAllAsReadOnlyAsync<Student>()
                .Where(s => s.ApplicationUserId == userId)
                .ExecuteUpdateAsync(setter => setter.SetProperty(s => s.RoomId, roomId));

            await _unitOfWork.GetAllAsReadOnlyAsync<Room>()
                .Where(r => r.Id == roomId)
                .ExecuteUpdateAsync(setter => setter.SetProperty(r => r.RemainingCapacity, r => r.RemainingCapacity - 1));
        }

        public Task<List<StudentWithoutARoomDto>> GetAllStudentsWithoutARoomAsync(int pageNumber) =>
            _unitOfWork.GetAllAsReadOnlyAsync<Student>()
            .Where(s => s.RoomId == null)
            .Skip((pageNumber - 1) * RoomlessStudentsListDto.StudentsOnPage)
            .Take(RoomlessStudentsListDto.StudentsOnPage)
            .Select(s => new StudentWithoutARoomDto
            {
                FullName = $"{s.ApplicationUser.FirstName} {s.ApplicationUser.LastName}",
                YearAtUniversity = s.YearAtUniversity
            })
            .ToListAsync();



        public async Task RemoveRecentlyGraduatedStudentsFromRoomsAsync() =>
            await _unitOfWork.GetAllAsReadOnlyAsync<Student>()
                 .Where(s => s.HasGraduated)
                 .ExecuteUpdateAsync(setter => setter.SetProperty(r => r.RoomId, (int?)null));

    }
}
