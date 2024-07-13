using RoomieFinderCore.Dtos.QuestionDtos;
using System.ComponentModel.DataAnnotations;

namespace RoomieFinderCore.Dtos.QuestionaireDtos
{
    public class FilledQuestionairePostDto
    {
        [Required]
        public int QuestionaireId { get; set; }

        [Required]
        public bool IsCompletelyFilled { get; set; }

        public List<int> ChosenAnswersIds { get; set; }
        = new List<int>();
    }
}
