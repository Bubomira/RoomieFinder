
namespace RoomieFinderCore.Contracts.QuestionaireContracts
{
    public interface IQuestionaireCheckerContract
    {

        /// <summary>
        /// Checks if a questionaire exist by a given id
        /// </summary>
        /// <param name="questionaireId"></param>
        /// <returns></returns>
        public Task<bool> CheckIfQuestionaireExistsByIdAsync(int questionaireId);



        /// <summary>
        /// Checks if a questionaire can be filled out by students or edited by the admins
        /// </summary>
        /// <param name="questionaireId"></param>
        /// <returns></returns>
        public Task<bool> CheckIfQuestionaireCanBeFilledOutAsync(int questionaireId);


        /// <summary>
        /// Checks if all of the submitted id's belong to the provided questionaire
        /// </summary>
        /// <param name="submittedQuestionsCount"></param>
        /// <returns></returns>
        public Task<bool> CheckIfAllAnswersBelongToTheQuestionaire(int questionaireId, List<int> expectedIds);

        /// <summary>
        /// Checks if a questionaire is filled out by a student
        /// </summary>
        /// <param name="questionaireId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public Task<bool> CheckIfQuestionaireIsFilledOutByStudentAsync(int questionaireId, string userId);
    }
}
