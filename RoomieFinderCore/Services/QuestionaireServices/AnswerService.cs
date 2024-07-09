

using Microsoft.EntityFrameworkCore;
using RoomieFinderCore.Contracts.QuestionaireContracts;
using RoomieFinderInfrastructure.Models;
using RoomieFinderInfrastructure.UnitOfWork;

using static RoomieFinderInfrastructure.Constants.ModelConstants.QuestionConstants;

namespace RoomieFinderCore.Services.QuestionaireServices
{
    public class AnswerService : IAnswerContract
    {
        private readonly IUnitOfWork _unitOfWork;

        public AnswerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task DeleteAnswerFromQuestionAsync(int answerId)
        {
            var answer = await _unitOfWork.GetById<Answer>(answerId);

            _unitOfWork.RemoveEntity(answer);

            await _unitOfWork.SaveChangesAsync();
        }

        public async Task UpdateAnswerAsync(int answerId, string content)
        {
            var answer = await _unitOfWork.GetById<Answer>(answerId);

            answer.Content = content;

            await _unitOfWork.SaveChangesAsync();
        }
        public Task<bool> CheckIfAnswerCouldBeDeletedFromQuestionAsync(int answerId) =>
            _unitOfWork.GetAllAsReadOnlyAsync<Answer>()
            .AnyAsync(a => a.Question.Answers.Count() > AnswerMinCount);

        public Task<bool> CheckIfAnswerExistsByIdAsync(int answerId) =>
            _unitOfWork.GetAllAsReadOnlyAsync<Answer>()
            .AnyAsync(a => a.Id == answerId);

        public Task<bool> CheckIfAnswerIsAttachedToEditableQuestionAsync(int answerId) =>
            _unitOfWork.GetAllAsReadOnlyAsync<Answer>()
            .AnyAsync(a => a.Id == answerId && a.Question.Questionnaire.IsReadyForFilling == true);

    }
}
