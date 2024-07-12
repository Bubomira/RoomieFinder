using RoomieFinderCore.Dtos.AnswerDtos;

namespace RoomieFinderCore.Contracts.AnswerContracts
{
    public interface IAnswerContract
    {
        /// <summary>
        /// Attaches new answer to an already existing question, admin only
        /// </summary>
        /// <param name="answerAttachDto"></param>
        /// <returns></returns>
        public Task AtachAnswerToQuestionAsync(AnswerAttachDto answerAttachDto);
        /// <summary>
        /// Deletes answer from database by id, admin only
        /// </summary>
        /// <param name="answerId"></param>
        /// <returns></returns>
        public Task DeleteAnswerFromQuestionAsync(int answerId);
        /// <summary>
        /// Updates answer content, admin only
        /// </summary>
        /// <param name="answerId"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public Task UpdateAnswerAsync(int answerId, string content);
        /// <summary>
        /// Checks if answer exists by its id
        /// </summary>
        /// <param name="answerId"></param>
        /// <returns></returns>

    }
}
