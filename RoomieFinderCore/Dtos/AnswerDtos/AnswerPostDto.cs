
using System.ComponentModel.DataAnnotations;
using static RoomieFinderInfrastructure.Constants.ModelConstants.AnswerConstants;
namespace RoomieFinderCore.Dtos.AnswerDtos
{
    public class AnswerPostDto
    {
        [Required]
        [StringLength(ContentMaxLength,MinimumLength =ContentMinLength)]
        public required string Content { get; set; }
    }
}
