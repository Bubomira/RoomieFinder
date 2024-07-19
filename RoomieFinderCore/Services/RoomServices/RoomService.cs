

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
            await _unitOfWork.GetAllAsync<Student>()
                .Where(s => s.ApplicationUserId == userId)
                .ExecuteUpdateAsync(setter => setter.SetProperty(s => s.RoomId, roomId));

            await _unitOfWork.GetAllAsync<Room>()
                .Where(r => r.Id == roomId)
                .ExecuteUpdateAsync(setter => setter.SetProperty(r => r.RemainingCapacity, r => r.RemainingCapacity - 1));
        }

        public async Task GetAllStudentsWithoutARoomAsync(StudentListDto roomlessStudentsListDto)
        {
            var students = _unitOfWork.GetAllAsReadOnlyAsync<Student>()
             .Where(s => s.RoomId == null);

            roomlessStudentsListDto.TotalCount = await students.CountAsync();

            roomlessStudentsListDto.Students = await students
            .Skip((roomlessStudentsListDto.PageNumber - 1) * StudentListDto.StudentsOnPage)
            .Take(StudentListDto.StudentsOnPage)
            .Select(s => new StudentPreviewDto
            {
                Id = s.ApplicationUserId,
                FullName = $"{s.ApplicationUser.FirstName} {s.ApplicationUser.LastName}",
                YearAtUniversity = s.YearAtUniversity
            })
            .ToListAsync();

        }

        public async Task RemoveRecentlyGraduatedStudentsFromRoomsAsync() =>
            await _unitOfWork.GetAllAsync<Student>()
                 .Where(s => s.HasGraduated)
                 .ExecuteUpdateAsync(setter => setter.SetProperty(r => r.RoomId, (int?)null));

        public async Task RemoveStudentFromARoomAsync(string userId) =>
            await _unitOfWork.GetAllAsync<Student>()
            .Where(s => s.ApplicationUserId == userId)
            .ExecuteUpdateAsync(setter => setter.SetProperty(r => r.RoomId, (int?)null));


    }
}
