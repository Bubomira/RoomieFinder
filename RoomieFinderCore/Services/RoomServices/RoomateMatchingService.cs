

using Microsoft.EntityFrameworkCore;
using RoomieFinderCore.Contracts.RoomContracts;
using RoomieFinderCore.Dtos.AnswerSheetDtos;
using RoomieFinderCore.Dtos.StudentDtos;
using RoomieFinderInfrastructure.Models;
using RoomieFinderInfrastructure.UnitOfWork;

using static RoomieFinderInfrastructure.Constants.ModelConstants.RoomConstants;

namespace RoomieFinderCore.Services.RoomServices
{
    public class RoomateMatchingService : IRoomateMatchingContract
    {
        private readonly IUnitOfWork _unitOfWork;
        public RoomateMatchingService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task GetRoomateMatchesForAStudentAsync(string userId, RoomateMatchesListDto roomateMatchesListDto)
        {
            // The general answers which a student has provided
            var studentGeneralAnswers = await _unitOfWork.GetAllAsReadOnlyAsync<AnswerSheet>()
                .Where(a => a.Student.ApplicationUserId == userId)
                .FirstAsync();

            // The ids of the qualities the current student has picked
            var studentQualityIds = await _unitOfWork.GetAllAsReadOnlyAsync<StudentQualities>()
                .Where(sq => sq.Student.ApplicationUserId == userId)
                .Select(sq => sq.QualityId)
                .ToListAsync();

            // Initial requirement are that the room a student is asiigned in still has capacity and that the gender matches
            var matches = _unitOfWork.GetAllAsReadOnlyAsync<Student>()
                .Where(s =>
                (s.Room == null || s.Room.RemainingCapacity != NoCapacityLeft)
                && s.IsMale == roomateMatchesListDto.IsMale
                && s.ApplicationUserId != userId
                && s.AnswerSheet != null);

            // the query orders the potential matches by the general answers first
            matches = matches
                .OrderBy(s => s.AnswerSheet.IsMessy == studentGeneralAnswers.IsMessy)
                .ThenBy(s => s.AnswerSheet.GoesToSleepEarly == studentGeneralAnswers.GoesToSleepEarly)
                .ThenBy(s => s.AnswerSheet.LikesQuietness == studentGeneralAnswers.LikesQuietness)
                .ThenBy(s => s.AnswerSheet.WakesUpEarly == studentGeneralAnswers.WakesUpEarly)
                .ThenBy(s => s.AnswerSheet.IsIntrovert == studentGeneralAnswers.IsIntrovert);

            //Final ordering by count of qualities which are present to both students
            matches = matches.OrderByDescending(m =>
                    m.StudentQualities.Count(sq => studentQualityIds.Contains(sq.QualityId)));

            roomateMatchesListDto.TotalCount = await matches.CountAsync();

            roomateMatchesListDto.BestMatches = await matches
                  .Skip((roomateMatchesListDto.PageNumber - 1) * RoomateMatchesListDto.MaxItemsOnRoomatePage)
                  .Take(RoomateMatchesListDto.MaxItemsOnRoomatePage)
                  .Select(s => new StudentBestMatchDto
                  {
                      Id=s.ApplicationUserId,
                      FullName = $"{s.ApplicationUser.FirstName} {s.ApplicationUser.LastName}",
                      YearAtUniversity = s.YearAtUniversity,
                      AssignedRoomId = s.RoomId,
                      HasAssignedRoom = s.Room != null,
                      AssignedRoomNumber = s.Room.RoomNumber,
                      RoomCapacityLeft = s.Room.RemainingCapacity,
                      AssignedDormitoryName = s.Room.Dormitory.Name,
                      AnswersAsUser = new AnswerSheetMetadataDto()
                      {
                          IsFilledOut=s.AnswerSheet!=null,
                          GoesToSleepEarly = s.AnswerSheet.GoesToSleepEarly==studentGeneralAnswers.GoesToSleepEarly,
                          LikesQuietness = s.AnswerSheet.LikesQuietness== studentGeneralAnswers.LikesQuietness,
                          IsIntrovert = s.AnswerSheet.IsIntrovert == studentGeneralAnswers.IsIntrovert,
                          IsMessy = s.AnswerSheet.IsMessy == studentGeneralAnswers.IsMessy,
                          WakesUpEarly = s.AnswerSheet.WakesUpEarly == studentGeneralAnswers.WakesUpEarly
                      }
                  })
                 .ToListAsync();
        }
    }
}
