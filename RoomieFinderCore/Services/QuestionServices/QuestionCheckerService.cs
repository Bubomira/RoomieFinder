using Microsoft.EntityFrameworkCore;
using RoomieFinderCore.Contracts.QuestionContracts;
using RoomieFinderInfrastructure.Models;
using RoomieFinderInfrastructure.UnitOfWork;

namespace RoomieFinderCore.Services.QuestionServices
{
    public class QuestionCheckerService : IQuestionCheckerContract
    {
        private readonly IUnitOfWork _unitOfWork;

        public QuestionCheckerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<bool> CheckIfQuestionExistsAsync(int questionId) =>
            _unitOfWork.GetAllAsReadOnlyAsync<Question>()
            .AnyAsync(q => q.Id == questionId);

        public Task<bool> CheckIfQuestionIsAttachedToQuestionaireAsync(int questionId, int questionaireId) =>
            _unitOfWork.GetAllAsReadOnlyAsync<Question>()
            .AnyAsync(q => q.QuestionnaireId == questionaireId && q.Id == questionId);

        public Task<bool> CheckIfQuestionaireIsAttachedToEditableQuestionaireAsync(int questionId) =>
            _unitOfWork.GetAllAsReadOnlyAsync<Question>()
            .AnyAsync(q => q.Id == questionId && q.Questionnaire.IsReadyForFilling == false);
    }
}
