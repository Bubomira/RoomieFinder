using Microsoft.EntityFrameworkCore;
using RoomieFinderCore.Contracts.QuestionaireContracts;
using RoomieFinderCore.Dtos.AnswerDtos;
using RoomieFinderCore.Dtos.QuestionaireDtos;
using RoomieFinderCore.Dtos.QuestionDtos;
using RoomieFinderInfrastructure.Enums;
using RoomieFinderInfrastructure.Models;
using RoomieFinderInfrastructure.UnitOfWork;

namespace RoomieFinderCore.Services.QuestionaireServices
{
    public class QuestionaireService : IQuestionaireContract
    {
        private readonly IUnitOfWork _unitOfWork;

        public QuestionaireService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public async Task AddQuestionaireWithQuestionsAsync(QuestionairePostDto questionairePostDto)
        {
            Questionnaire questionaire = new Questionnaire()
            {
                Description = questionairePostDto.Description,
                IsReadyForFilling = false,
                Title = questionairePostDto.Title,
                Questions = questionairePostDto.Questions.Select(q => new Question()
                {
                    Content = q.Content,
                    IsSingleAnswer = q.IsSingleAnswer,
                    Answers = q.PossibleAnswers.Select(pa => new Answer()
                    {
                        Content = q.Content
                    }).ToList()
                }).ToList()
            };

            await _unitOfWork.AddEntityAsync(questionaire);
            await _unitOfWork.SaveChangesAsync();

        }

        public async Task DeleteQuestionaireAsync(int questionaireId)
        {
            var questionaire = await _unitOfWork.GetById<Questionnaire>(questionaireId);

            _unitOfWork.RemoveEntity(questionaire);

            await _unitOfWork.SaveChangesAsync();
        }



        public async Task UpdateQuestionaireAsync(QuestionaireUpdateDto questionaireUpdateDto)
        {
            var questionaire = await _unitOfWork.GetById<Questionnaire>(questionaireUpdateDto.Id);

            questionaire.Description = questionaireUpdateDto.Description;
            questionaire.Title = questionaireUpdateDto.Title;

            await _unitOfWork.SaveChangesAsync();
        }

        public async Task MakeQuestionaireFillableAsync(int questionaireId)
        {
            var questionaire = await _unitOfWork.GetById<Questionnaire>(questionaireId);

            questionaire.IsReadyForFilling = true;

            await _unitOfWork.SaveChangesAsync();
        }
    }
}
