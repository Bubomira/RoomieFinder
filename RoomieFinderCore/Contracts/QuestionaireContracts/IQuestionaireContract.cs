

using RoomieFinderCore.Dtos.QuestionaireDtos;

namespace RoomieFinderCore.Contracts.QuestionaireContracts
{
    public interface IQuestionaireContract
    {
        /// <summary>
        /// Gets the details about an unfilled questionaire- either the empty form for admins or the fillable vesrion for students
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<UnfilledQuestionnaireDetailsDto?> GetQuestionaireByIdAsync(int id);
        /// <summary>
        /// Gets all available questionairs with sorting and search functionality
        /// Students can only see the questionairs they can fill out
        /// </summary>
        /// <param name="questionaireQueryInformationDto"></param>
        /// <param name="isAdmin"></param>
        /// <returns></returns>
        public Task GetQuestionairsAsync(QuestionaireQueryInformationDto questionaireQueryInformationDto, bool isAdmin);

        /// <summary>
        /// Adds the initial version of a questionaire, along with questions an dtheir answers
        /// </summary>
        /// <param name="questionairePostDto"></param>
        /// <returns></returns>
        public Task AddQuestionaireWithQuestionsAsync(QuestionairePostDto questionairePostDto);

        /// <summary>
        /// Updates questionaire's title and description
        /// </summary>
        /// <param name="questionaireUpdateDto"></param>
        /// <returns></returns>
        public Task UpdateQuestionaireAsync(QuestionaireUpdateDto questionaireUpdateDto);

        /// <summary>
        /// This makes questionary visible to students as well, once done cannot be reverted
        /// </summary>
        /// <param name="questionaireId"></param>
        /// <returns></returns>
        public Task MakeQuestionaireFillableAsync(int questionaireId);

        /// <summary>
        /// Deletes the questionaire alongside with all of its questions and their answers
        /// Once done cannot be reverted
        /// </summary>
        /// <param name="questionaireId"></param>
        /// <returns></returns>
        public Task DeleteQuestionaireAsync(int questionaireId);

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
        public Task<bool> CheckIfQuestionaireCanBeFilledOut(int questionaireId);
    }
}
