using Microsoft.EntityFrameworkCore;
using RoomieFinderCore.Contracts.QuestionaireContracts;
using RoomieFinderCore.Dtos.AnswerDtos;
using RoomieFinderCore.Dtos.QuestionaireDtos;
using RoomieFinderCore.Dtos.QuestionDtos;
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
                Title = questionairePostDto.Title,
                Questions = questionairePostDto.Questions.Select(q => new Question()
                {
                    Content = q.Content,
                    IsSingleAnswer = q.IsSingleAnswer,
                    Answers= q.PossibleAnswers.Select(pa => new Answer()
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

        public async Task<UnfilledQuestionnaireDetailsDto?> GetQuestionaireByIdAsync(int id) =>
           await _unitOfWork.GetAllAsReadOnlyAsync<Questionnaire>()
            .Where(q => q.Id == id)
            .Select(q => new UnfilledQuestionnaireDetailsDto()
            {
                Id = q.Id,
                Description = q.Description,
                Title = q.Title,
                Questions = q.Questions.Select(qu => new QuestionDetailsDto()
                {
                    Id = qu.Id,
                    Content = qu.Content,
                    IsSingleAnswer = qu.IsSingleAnswer,
                    Answers = qu.Answers.Select(a => new AnswerDetailsDto()
                    {
                        Id = a.Id,
                        IsPicked = false,
                        Content = a.Content
                    }).ToList()
                }).ToList()
            })
            .FirstOrDefaultAsync();





        public async Task UpdateQuestionaireAsync(QuestionaireUpdateDto questionaireUpdateDto)
        {
            var questionaire = await _unitOfWork.GetById<Questionnaire>(questionaireUpdateDto.Id);

            questionaire.Description = questionaireUpdateDto.Description;
            questionaire.Title = questionaireUpdateDto.Title;

            await _unitOfWork.SaveChangesAsync();
        }

        public Task<bool> CheckIfQuestionaireExistsByIdAsync(int questionaireId) =>
             _unitOfWork.GetAllAsReadOnlyAsync<Questionnaire>()
             .AnyAsync(q => q.Id == questionaireId);

    }
}
