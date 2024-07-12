using Microsoft.EntityFrameworkCore;
using RoomieFinderCore.Contracts.AnswerContracts;
using RoomieFinderInfrastructure.Models;
using RoomieFinderInfrastructure.UnitOfWork;

using static RoomieFinderInfrastructure.Constants.ModelConstants.QuestionConstants;

namespace RoomieFinderCore.Services.AnswerService
{
    public class AnswerCheckerService : IAnswerCheckerContract
    {

        private readonly IUnitOfWork _unitOfWork;

        public AnswerCheckerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Task<bool> CheckIfAnswerCouldBeDeletedFromQuestionAsync(int answerId) =>
           _unitOfWork.GetAllAsReadOnlyAsync<Answer>()
           .AnyAsync(a => a.Question.Answers.Count() > AnswerMinCount);

        public Task<bool> CheckIfAnswerExistsByIdAsync(int answerId) =>
            _unitOfWork.GetAllAsReadOnlyAsync<Answer>()
            .AnyAsync(a => a.Id == answerId);

        public Task<bool> CheckIfAnswerIsAttachedToEditableQuestionAsync(int answerId) =>
            _unitOfWork.GetAllAsReadOnlyAsync<Answer>()
            .AnyAsync(a => a.Id == answerId && a.Question.Questionnaire.IsReadyForFilling == false);

        public Task<bool> CheckIfThereIsAnotherAnswerWithTheSameContentAsync(int questionId, string content) =>
            _unitOfWork.GetAllAsReadOnlyAsync<Question>()
            .AnyAsync(q => q.Id == questionId
            && q.Answers.All(a => a.Content != content));

        public Task<bool> CheckIfAllAnswersExistByIdsAsync(List<int> answersId) =>
            _unitOfWork.GetAllAsReadOnlyAsync<Answer>()
            .AllAsync(a => answersId.Contains(a.Id));
    }
}
