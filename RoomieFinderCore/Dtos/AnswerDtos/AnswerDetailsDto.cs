using System.ComponentModel.DataAnnotations;
using static RoomieFinderInfrastructure.Constants.ModelConstants.AnswerConstants;

namespace RoomieFinderCore.Dtos.AnswerDtos
{
    public class AnswerDetailsDto
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(ContentMaxLength, MinimumLength = ContentMinLength)]
        public required string Content { get; set; }

        [Required]
        public required bool IsPicked { get; set; } = false;
    }
}
