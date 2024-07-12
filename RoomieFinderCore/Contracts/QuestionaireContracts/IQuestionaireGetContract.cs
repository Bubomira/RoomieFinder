

using RoomieFinderCore.Dtos.QuestionaireDtos;

namespace RoomieFinderCore.Contracts.QuestionaireContracts
{
    public interface IQuestionaireGetContract
    {
        /// <summary>
        /// Gets the details about an unfilled questionaire- either the empty form for admins or the fillable vesrion for students
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<FilledQuestionaireDto?> GetQuestionaireByIdAsync(int id);
        /// <summary>
        /// Gets all available questionairs with sorting and search functionality
        /// Students can only see the questionairs they can fill out
        /// </summary>
        /// <param name="questionaireQueryInformationDto"></param>
        /// <param name="isAdmin"></param>
        /// <returns></returns>
        public Task GetQuestionairsAsync(QuestionaireQueryInformationDto questionaireQueryInformationDto, bool isAdmin);
    }
}
