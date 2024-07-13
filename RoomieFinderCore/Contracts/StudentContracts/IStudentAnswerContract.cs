using RoomieFinderCore.Dtos.QuestionaireDtos;
using RoomieFinderCore.Dtos.QuestionDtos;

namespace RoomieFinderCore.Contracts.StudentContracts
{
    public interface IStudentAnswerContract
    {
        /// <summary>
        /// Upload the answers given by a student for a questionaire
        /// </summary>
        /// <param name="studentId"></param>
        /// <param name="answeredQuestionDto"></param>
        /// <returns></returns>
        public Task UploadAnswersAsync(int studentId, List<int> selectedIds);

        /// <summary>
        /// Deletes all answers for a questionaire by student id
        /// </summary>
        /// <param name="studentId"></param>
        /// <returns></returns>
        public Task ResetStudentAnswersForAStudentAsync(int studentId,int questionaireId);


    }
}
