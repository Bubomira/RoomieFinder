

using Microsoft.EntityFrameworkCore;
using RoomieFinderCore.Contracts.StudentContracts;
using RoomieFinderCore.Dtos.StudentDtos;
using RoomieFinderInfrastructure.Models;
using RoomieFinderInfrastructure.UnitOfWork;

using static RoomieFinderInfrastructure.Constants.ModelConstants.StudentConstants;

using static RoomieFinderInfrastructure.Constants.ModelConstants.RoomConstants;

namespace RoomieFinderCore.Services.StudentServices
{
    public class StudentService : IStudentContract
    {
        private readonly IUnitOfWork _unitOfWork;
        public StudentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Task<int> GetStudentIdAsync(string userId) =>
            _unitOfWork.GetAllAsReadOnlyAsync<Student>()
            .Where(s => s.ApplicationUserId == userId)
            .Select(s => s.StudentId)
            .FirstOrDefaultAsync();

        public Task<bool> CheckIfStudentIsMale(string userId) =>
           _unitOfWork.GetAllAsReadOnlyAsync<Student>()
           .Where(s => s.ApplicationUserId == userId)
           .Select(s => s.IsMale)
           .FirstOrDefaultAsync();

        public async Task<List<StudentBestMatchDto>> GetTopThreeRoomateMatchesForAStudentAsync(string userId, bool isMale)
        {
            var studentAnswersIds = await _unitOfWork.GetAllAsReadOnlyAsync<StudentAnswer>()
                .Where(sa => sa.Student.ApplicationUserId == userId)
                .Select(sa => sa.AnswerId)
                .ToListAsync();

            // Initial requirement are that the room a student is asiigned in still has capacity and that the gender matches
            var studentsWhoMatchInitialRequirements = _unitOfWork.GetAllAsReadOnlyAsync<Student>()
                .Where(s =>
                (s.Room == null || s.Room.RemainingCapacity != NoCapacityLeft)
                && s.IsMale == isMale
                && s.ApplicationUserId != userId);

            var topThreeBestMathches = studentsWhoMatchInitialRequirements
                .OrderByDescending(s => s.StudentAnswers.Count(sa => studentAnswersIds.Contains(sa.AnswerId)))
                .Take(3);

            return await topThreeBestMathches.Select(s => new StudentBestMatchDto
            {
                FullName = $"{s.ApplicationUser.FirstName} {s.ApplicationUser.LastName}",
                YearAtUniversity = s.YearAtUniversity,
                AssignedRoomId = s.RoomId,
                HasAssignedRoom = s.Room != null,
                AssignedRoomNumber = s.Room.RoomNumber,
                RoomCapacityLeft = s.Room.RemainingCapacity,
                AssignedDormitoryName = s.Room.Dormitory.Name
            })
            .ToListAsync();
        }

        public async Task MoveUngraduatedStudentsToNextYearAsync()
        {
            await _unitOfWork.GetAllAsReadOnlyAsync<Student>()
                 .Where(s => s.YearAtUniversity < TopYearAtUniversity)
                 .ExecuteUpdateAsync(setters => setters.SetProperty(s => s.YearAtUniversity, s => s.YearAtUniversity + 1));
        }

        public async Task GraduateStudentsAsync()
        {
            await _unitOfWork.GetAllAsReadOnlyAsync<Student>()
                 .Where(s => s.YearAtUniversity == TopYearAtUniversity)
                 .ExecuteUpdateAsync(setters => setters.SetProperty(s => s.HasGraduated, true));
        }
    }
}
