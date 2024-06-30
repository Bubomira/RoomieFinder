using System.ComponentModel.DataAnnotations;

using static RoomieFinderInfrastructure.Constants.ModelConstants.QuestionConstants;

namespace RoomieFinderCore.Dtos.QuestionDtos
{
    public class QuestionUpdateMetadataDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(TitleMaxLength, MinimumLength = TitleMinLength)]
        public required string Title { get; set; }


        [Required]
        public required bool IsSingleAnswer { get; set; }
    }
}
