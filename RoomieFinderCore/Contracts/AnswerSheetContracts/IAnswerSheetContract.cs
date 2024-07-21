using RoomieFinderCore.Dtos.AnswerSheetDtos;

namespace RoomieFinderCore.Contracts.AnswerSheetContracts
{
    public interface IAnswerSheetContract
    {

        /// <summary>
        /// Saves the student preferred answers
        /// </summary>
        /// <returns></returns>
        public Task SaveAnswerSheetAnswersAsync(AnswerSheetPostDto answerSheetPostDto, int studentId);

    }
}
