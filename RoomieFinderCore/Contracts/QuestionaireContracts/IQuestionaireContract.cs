

using RoomieFinderCore.Dtos.QuestionaireDtos;

namespace RoomieFinderCore.Contracts.QuestionaireContracts
{
    public interface IQuestionaireContract
    {
        public Task<UnfilledQuestionnaireDetailsDto?> GetQuestionaireByIdAsync(int id);
        public Task GetQuestionairsAsync(QuestionaireQueryInformationDto questionaireQueryInformationDto, bool isAdmin);
        public Task AddQuestionaireWithQuestionsAsync(QuestionairePostDto questionairePostDto);
        public Task UpdateQuestionaireAsync(QuestionaireUpdateDto questionaireUpdateDto);

        /// <summary>
        /// This makes questionary visible to students as well, once done cannot be reverted
        /// </summary>
        /// <param name="questionaireId"></param>
        /// <returns></returns>
        public Task MakeQuestionaireFillableAsync(int questionaireId);
        public Task DeleteQuestionaireAsync(int questionaireId);
        public Task<bool> CheckIfQuestionaireExistsByIdAsync(int questionaireId);
        public Task<bool> CheckIfQuestionaireCanBeFilledOut(int questionaireId);
    }
}
