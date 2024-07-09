

namespace RoomieFinderCore.Contracts.QuestionaireContracts
{
    public interface IAnswerContract
    {
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
    }
}
