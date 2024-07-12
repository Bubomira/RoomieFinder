using RoomieFinderCore.Contracts.AnswerContracts;
using RoomieFinderCore.Dtos.AnswerDtos;
using RoomieFinderInfrastructure.Models;
using RoomieFinderInfrastructure.UnitOfWork;

namespace RoomieFinderCore.Services.AnswerService
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
        public async Task AtachAnswerToQuestionAsync(AnswerAttachDto answerAttachDto)
        {
            Answer answer = new Answer()
            {
                Content = answerAttachDto.Content,
                QuestionId = answerAttachDto.QuestionId
            };

            await _unitOfWork.AddEntityAsync(answer);
            await _unitOfWork.SaveChangesAsync();
        }


    }
}
