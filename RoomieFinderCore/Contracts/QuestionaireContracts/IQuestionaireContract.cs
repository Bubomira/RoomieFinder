

using RoomieFinderCore.Dtos.QuestionaireDtos;

namespace RoomieFinderCore.Contracts.QuestionaireContracts
{
    public interface IQuestionaireContract
    {       

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

    }
}
