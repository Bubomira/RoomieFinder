

using RoomieFinderCore.Dtos.QuestionaireDtos;

namespace RoomieFinderCore.Contracts.QuestionaireContracts
{
    public interface IQuestionaireContract
    {
        public Task AddQuestionaireWithQuestionsAsync(QuestionairePostDto questionairePostDto);
        public Task<UnfilledQuestionnaireDetailsDto?> GetQuestionaireByIdAsync(int id);
        public Task UpdateQuestionaireAsync(QuestionaireUpdateDto questionaireUpdateDto);
        public Task DeleteQuestionaireAsync(int questionaireId);
        public Task<bool> CheckIfQuestionaireExistsByIdAsync(int questionaireId);
    }
}
