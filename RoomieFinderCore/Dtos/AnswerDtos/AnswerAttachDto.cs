using System.ComponentModel.DataAnnotations;

namespace RoomieFinderCore.Dtos.AnswerDtos
{
    public class AnswerAttachDto : AnswerPostDto
    {
        [Required]
        public int QuestionId { get; set; }
    }
}
