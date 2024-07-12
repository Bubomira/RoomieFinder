
namespace RoomieFinderCore.Contracts.AnswerContracts
{
    public interface IAnswerCheckerContract
    {
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
        /// <summary>
        /// Checks if all of the provided ids are valid answer ids
        /// </summary>
        /// <param name="answersId"></param>
        /// <returns></returns>
        public Task<bool> CheckIfAllAnswersExistByIdsAsync(List<int> answersId);
    }
}
