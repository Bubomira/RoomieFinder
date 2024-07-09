
using System.ComponentModel.DataAnnotations;

namespace RoomieFinderCore.Dtos.AnswerDtos
{
    public class AnswerUpdateDto : AnswerPostDto
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int QuestionId { get; set; }

        [Required]
        public int QuestionaireId { get; set; }

    }
}
