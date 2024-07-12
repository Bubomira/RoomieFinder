

namespace RoomieFinderCore.Contracts.QuestionContracts
{
    public interface IQuestionCheckerContract
    {
        /// <summary>
        /// Checks if a questionaire exists by an id
        /// </summary>
        /// <param name="questionId"></param>
        /// <returns></returns>
        public Task<bool> CheckIfQuestionExistsAsync(int questionId);

        /// <summary>
        /// Checks if a question is attached to a questionaire by their respective ids
        /// </summary>
        /// <param name="questionId"></param>
        /// <param name="questionaireId"></param>
        /// <returns></returns>
        public Task<bool> CheckIfQuestionIsAttachedToQuestionaireAsync(int questionId, int questionaireId);

        /// <summary>
        /// Checks if a question is attached to an editable questionaire by its id
        /// </summary>
        /// <param name="questionId"></param>
        /// <returns></returns>
        public Task<bool> CheckIfQuestionaireIsAttachedToEditableQuestionaireAsync(int questionId);
    }
}
