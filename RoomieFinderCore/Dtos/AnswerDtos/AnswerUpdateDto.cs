
using System.ComponentModel.DataAnnotations;

namespace RoomieFinderCore.Dtos.AnswerDtos
{
    public class AnswerUpdateDto : AnswerAttachDto
    {
        [Required]
        public int Id { get; set; }

    }
}
