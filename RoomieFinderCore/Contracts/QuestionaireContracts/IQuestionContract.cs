using RoomieFinderCore.Dtos.QuestionDtos;


namespace RoomieFinderCore.Contracts.QuestionaireContracts
{
    public interface IQuestionContract
    {
        public Task AddQuestionToQuestionaireAsync(int questionaireId, QuestionPostDto questionPostDto);
        public Task UpdateQuestionMetadataAsync(int questionId, QuestionPostDto questionPostDto);
        public Task DeleteQuestionFromQuestionaireAsync(int questionId);
        public Task<bool> CheckIfQuestionExistsAsync(int questionId);
        public Task<bool> CheckIfQuestionIsAttachedToQuestionaireAsync(int questionId, int questionaireId);
    }
}
