using RoomieFinderCore.Contracts.AnswerSheetContracts;
using RoomieFinderCore.Dtos.AnswerSheetDtos;
using RoomieFinderInfrastructure.Models;
using RoomieFinderInfrastructure.UnitOfWork;

namespace RoomieFinderCore.Services.AnswerSheetServices
{
    public class AnswerSheetService : IAnswerSheetContract
    {
        private readonly IUnitOfWork _unitOfWork;
        public AnswerSheetService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task SaveAnswerSheetAnswersAsync(AnswerSheetPostDto answerSheetPostDto, int studentId)
        {
            AnswerSheet answerSheet = new AnswerSheet()
            {
                StudentId = studentId,
                GoesToSleepEarly = answerSheetPostDto.GoesToSleepEarly,
                LikesQuietness = answerSheetPostDto.LikesQuietness,
                WakesUpEarly = answerSheetPostDto.WakesUpEarly,
                IsIntrovert = answerSheetPostDto.IsIntrovert,
                IsMessy = answerSheetPostDto.IsMessy,
                IsEditable = false,
            };

            await _unitOfWork.AddEntityAsync(answerSheet);

            await _unitOfWork.SaveChangesAsync();
        }
    }
}
