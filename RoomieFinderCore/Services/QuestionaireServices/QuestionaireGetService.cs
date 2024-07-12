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
    public class QuestionaireGetService : IQuestionaireGetContract
    {
        private readonly IUnitOfWork _unitOfWork;

        public QuestionaireGetService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<QuestionaireDetailsDto?> GetQuestionaireByIdAsync(int id, bool isFilledOut, string userId) => await _unitOfWork.GetAllAsReadOnlyAsync<Questionnaire>()
              .Where(q => q.Id == id)
              .Select(q => new QuestionaireDetailsDto()
              {
                  Id = q.Id,
                  Description = q.Description,
                  CanBeFilledOut = q.IsReadyForFilling,
                  Title = q.Title,
                  Questions = q.Questions.Select(qu => new QuestionDetailsDto()
                  {
                      Id = qu.Id,
                      Content = qu.Content,
                      IsSingleAnswer = qu.IsSingleAnswer,
                      Answers = qu.Answers.Select(a => new AnswerDetailsDto()
                      {
                          Id = a.Id,
                          IsPicked = isFilledOut ? false : a.StudentAnswers.Any(sa => sa.AnswerId == a.Id && sa.Student.ApplicationUserId == userId),
                          Content = a.Content
                      }).ToList()
                  }).ToList()
              })
            .FirstOrDefaultAsync();

        public async Task GetQuestionairsAsync(QuestionaireQueryInformationDto questionaireQueryInformationDto, bool isAdmin)
        {
            var questionairs = _unitOfWork.GetAllAsReadOnlyAsync<Questionnaire>();

            if (isAdmin)
            {
                if (questionaireQueryInformationDto.CanQuestionaireBeEdited == CanQuestionaireBeEdited.Yes)
                {
                    questionairs = questionairs.Where(q => q.IsReadyForFilling == true);
                }
                else if (questionaireQueryInformationDto.CanQuestionaireBeEdited == CanQuestionaireBeEdited.No)
                {
                    questionairs = questionairs.Where(q => q.IsReadyForFilling == false);
                }
            }
            else
            {
                questionairs = questionairs.Where(q => q.IsReadyForFilling == true);
            }

            var searchString = questionaireQueryInformationDto.SearchString;
            if (!string.IsNullOrEmpty(searchString))
            {
                searchString = searchString.ToLower();
                questionairs = questionairs.Where(q => q.Title.ToLower() == searchString
                || q.Description.ToLower() == searchString);
            }

            questionaireQueryInformationDto.TotalResults = await questionairs.CountAsync();

            questionaireQueryInformationDto.QuestionairePreviewDtos =
               await questionairs
                .Skip(questionaireQueryInformationDto.PageNumber - 1 * QuestionaireQueryInformationDto.ItemsPerPage)
                .Take(QuestionaireQueryInformationDto.ItemsPerPage)
                .Select(q => new QuestionairePreviewDto()
                {
                    Id = q.Id,
                    Title = q.Title,
                    Description = q.Description,
                    CanQuestionaireBeEdited = q.IsReadyForFilling
                })
                .ToListAsync();
        }


    }
}
