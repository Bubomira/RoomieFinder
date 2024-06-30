using Microsoft.EntityFrameworkCore;
using RoomieFinderCore.Contracts.QuestionaireContracts;
using RoomieFinderCore.Dtos.QuestionDtos;
using RoomieFinderInfrastructure.Models;
using RoomieFinderInfrastructure.UnitOfWork;

namespace RoomieFinderCore.Services.QuestionaireServices
{
    public class QuestionService : IQuestionContract
    {
        private readonly IUnitOfWork _unitOfWork;

        public QuestionService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddQuestionToQuestionaireAsync(int questionaireId, QuestionPostDto questionPostDto)
        {
            Question question = new Question()
            {
                Content = questionPostDto.Content,
                IsSingleAnswer = questionPostDto.IsSingleAnswer,
                QuestionnaireId = questionaireId,
                Answers = questionPostDto.PossibleAnswers.Select(pa => new Answer()
                {
                    Content = pa.Content
                }).ToList()
            };

            await _unitOfWork.AddEntityAsync(question);
            await _unitOfWork.SaveChangesAsync();
        }


        public async Task DeleteQuestionFromQuestionaireAsync(int questionId)
        {
            var question = await _unitOfWork.GetById<Question>(questionId);

            _unitOfWork.RemoveEntity(question);

            await _unitOfWork.SaveChangesAsync();
        }

        public async Task UpdateQuestionMetadataAsync(int questionId, QuestionPostDto questionPostDto)
        {
            var question = await _unitOfWork.GetById<Question>(questionId);

            question.IsSingleAnswer = questionPostDto.IsSingleAnswer;
            question.Content = questionPostDto.Content;

            await _unitOfWork.SaveChangesAsync();
        }


        public Task<bool> CheckIfQuestionExistsAsync(int questionId) =>
            _unitOfWork.GetAllAsReadOnlyAsync<Question>()
            .AnyAsync(q => q.Id == questionId);

        public Task<bool> CheckIfQuestionIsAttachedToQuestionaireAsync(int questionId, int questionaireId) =>
            _unitOfWork.GetAllAsReadOnlyAsync<Question>()
            .AnyAsync(q => q.QuestionnaireId == questionaireId && q.Id == questionId);

    }
}
