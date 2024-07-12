

using Microsoft.EntityFrameworkCore;
using RoomieFinderCore.Contracts.QuestionaireContracts;
using RoomieFinderInfrastructure.Models;
using RoomieFinderInfrastructure.UnitOfWork;

namespace RoomieFinderCore.Services.QuestionaireServices
{
    public class QuestionaireCheckerService : IQuestionaireCheckerContract
    {

        private readonly IUnitOfWork _unitOfWork;

        public QuestionaireCheckerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<bool> CheckIfQuestionaireExistsByIdAsync(int questionaireId) =>
         _unitOfWork.GetAllAsReadOnlyAsync<Questionnaire>()
         .AnyAsync(q => q.Id == questionaireId);

        public Task<bool> CheckIfQuestionaireCanBeFilledOutAsync(int questionaireId) =>
            _unitOfWork.GetAllAsReadOnlyAsync<Questionnaire>()
            .AnyAsync(q => q.Id == questionaireId && q.IsReadyForFilling);

        public Task<bool> CheckIfAllAnswersHaveBeenAnsweredAsync(int questionaireId, int submittedQuestionsCount) =>
            _unitOfWork.GetAllAsReadOnlyAsync<Questionnaire>()
            .AnyAsync(q => q.Id == questionaireId && q.Questions.Count == submittedQuestionsCount);

    }
}
