

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

        public Task<bool> CheckIfAllAnswersBelongToTheQuestionaire(int questionaireId, List<int> submittedIds) =>
            _unitOfWork.GetAllAsReadOnlyAsync<StudentAnswer>()
            .Where(sa => sa.Answer.Question.QuestionnaireId == questionaireId)
            .AllAsync(sa => submittedIds.Contains(sa.AnswerId));

        public Task<bool> CheckIfQuestionaireIsFilledOutByStudentAsync(int questionaireId, string userId) =>
            _unitOfWork.GetAllAsReadOnlyAsync<StudentAnswer>()
            .AnyAsync(sa => sa.Answer.Question.Questionnaire.Id == questionaireId && sa.Student.ApplicationUserId == userId);

    }
}
