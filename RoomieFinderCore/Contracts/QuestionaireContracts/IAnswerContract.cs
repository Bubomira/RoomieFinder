

using RoomieFinderCore.Dtos.AnswerDtos;

namespace RoomieFinderCore.Contracts.QuestionaireContracts
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
        public Task<bool> CheckIfAnswerExistsByIdAsync(int answerId);
        /// <summary>
        /// Checks if the answer can be edited by checking the status of the questionaire its in
        /// </summary>
        /// <param name="answerId"></param>
        /// <returns></returns>
        public Task<bool> CheckIfAnswerIsAttachedToEditableQuestionAsync(int answerId);
        /// <summary>
        /// Checks if the answer could be deleted from a question by seeing how many answers a question has left
        /// </summary>
        /// <param name="answerId"></param>
        /// <returns></returns>
        public Task<bool> CheckIfAnswerCouldBeDeletedFromQuestionAsync(int answerId);
        /// <summary>
        /// Checks if there is already an answer with the same content for a given question
        /// </summary>
        /// <param name="answerAttachDto"></param>
        /// <returns></returns>
        public Task<bool> CheckIfThereIsAnotherAnswerWithTheSameContentAsync(int questionId, string content);
    }
}
