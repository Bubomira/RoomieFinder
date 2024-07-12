using RoomieFinderCore.Dtos.QuestionDtos;
using System.ComponentModel.DataAnnotations;

namespace RoomieFinderCore.Dtos.QuestionaireDtos
{
    public class FilledQuestionairePostDto
    {
        [Required]
        public int QuestionaireId { get; set; }

        [Required]
        public required string UserId { get; set; }

        public List<AnsweredQuestionDto> AnsweredQuestions { get; set; }
         = new List<AnsweredQuestionDto>();
    }
}
