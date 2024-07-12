using Microsoft.EntityFrameworkCore;
using RoomieFinderCore.Contracts.QuestionContracts;
using RoomieFinderCore.Dtos.QuestionDtos;
using RoomieFinderInfrastructure.Models;
using RoomieFinderInfrastructure.UnitOfWork;

namespace RoomieFinderCore.Services.QuestionService
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

        public async Task UpdateQuestionMetadataAsync(int questionId, QuestionUpdateMetadataDto questionUpdateMetadataDto)
        {
            var question = await _unitOfWork.GetById<Question>(questionId);

            question.IsSingleAnswer = questionUpdateMetadataDto.IsSingleAnswer;
            question.Content = questionUpdateMetadataDto.Title;

            await _unitOfWork.SaveChangesAsync();
        }


    }
}
