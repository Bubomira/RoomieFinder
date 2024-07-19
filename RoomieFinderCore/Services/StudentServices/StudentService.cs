

using Microsoft.EntityFrameworkCore;
using RoomieFinderCore.Contracts.StudentContracts;
using RoomieFinderCore.Dtos.StudentDtos;
using RoomieFinderInfrastructure.Models;
using RoomieFinderInfrastructure.UnitOfWork;

using static RoomieFinderInfrastructure.Constants.ModelConstants.StudentConstants;

using static RoomieFinderInfrastructure.Constants.ModelConstants.RoomConstants;
using RoomieFinderInfrastructure.Enums;
using RoomieFinderCore.Dtos.RequestDtos;

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

        public Task<string?> GetUserIdByEmailAsync(string email) =>
            _unitOfWork.GetAllAsReadOnlyAsync<ApplicationUser>()
            .Where(au => au.Email == email)
            .Select(au => au.Id)
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
        public Task<StudentProfileDto> GetStudentProfile(string userId) =>
            _unitOfWork.GetAllAsReadOnlyAsync<ApplicationUser>()
            .Where(au => au.Id == userId)
            .Select(au => new StudentProfileDto()
            {
                Id = au.Id,
                Fullname = $"{au.FirstName} {au.LastName}",
                Email = au.Email,
                UserName = au.UserName,
                YearAtUiversity = au.Student.YearAtUniversity,
                IsMale = au.Student.IsMale,
                Roomates = au.Student.Room.Students
                .Where(s => s.ApplicationUserId != userId)
                .Select(s => new RoomateDto()
                {
                    Id = s.ApplicationUserId,
                    FullName = $"{s.ApplicationUser.FirstName} {s.ApplicationUser.LastName}",
                    YearAtUniversity = s.YearAtUniversity
                })
                .ToList(),
                Requests = au.Student.Requests
                .Where(r => r.Student.ApplicationUserId == userId && r.RequestStatus != RequestStatus.Archived)
                .Select(r => new RequestPreviewDto()
                {
                    Id = r.Id,
                    RequestStatus = r.RequestStatus,
                    RequestType = r.RequestType
                })
                .ToList()
            })
            .FirstAsync();

        public async Task GetAllStudents(StudentSeachListDto studentListDto)
        {
            var students = _unitOfWork.GetAllAsReadOnlyAsync<Student>();

            switch (studentListDto.AreGraduated)
            {
                case AreGraduated.Yes:
                    students = students.Where(s => s.HasGraduated);
                    break;
                case AreGraduated.No:
                    students = students.Where(s => !s.HasGraduated);
                    break;
            }

            switch (studentListDto.GenderPreference)
            {
                case GenderPreference.Male:
                    students = students.Where(s => s.IsMale);
                    break;
                case GenderPreference.Female:
                    students = students.Where(s => !s.IsMale);
                    break;
            }

            if (!string.IsNullOrEmpty(studentListDto.SearchTerm))
            {
                var searchTerm = studentListDto.SearchTerm.ToLower();

                students = students.Where(s =>
                $"{s.ApplicationUser.FirstName} {s.ApplicationUser.LastName}".ToLower().Contains(searchTerm));
            }

            studentListDto.TotalCount = await students.CountAsync();

            studentListDto.Students = await students
                .Skip((studentListDto.PageNumber - 1) * StudentListDto.StudentsOnPage)
                .Take(StudentListDto.StudentsOnPage)
                .Select(s => new StudentPreviewDto()
                {
                    Id = s.ApplicationUserId,
                    FullName = $"{s.ApplicationUser.FirstName} {s.ApplicationUser.LastName}",
                    YearAtUniversity = s.YearAtUniversity,
                })
                .ToListAsync();
        }


        public async Task MoveUngraduatedStudentsToNextYearAsync()
        {
            await _unitOfWork.GetAllAsync<Student>()
                 .Where(s => s.YearAtUniversity < TopYearAtUniversity)
                 .ExecuteUpdateAsync(setters => setters.SetProperty(s => s.YearAtUniversity, s => s.YearAtUniversity + 1));
        }

        public async Task GraduateStudentsAsync()
        {
            await _unitOfWork.GetAllAsync<Student>()
                 .Where(s => s.YearAtUniversity == TopYearAtUniversity)
                 .ExecuteUpdateAsync(setters => setters.SetProperty(s => s.HasGraduated, true));
        }


    }
}
