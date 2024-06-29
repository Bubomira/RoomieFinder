using System.ComponentModel.DataAnnotations;
using static RoomieFinderInfrastructure.Constants.ModelConstants.QuestionnaireConstants;

namespace RoomieFinderCore.Dtos.QuestionaireDtos
{
    public class QuestionaireUpdateDto
    {
        [Required]
        public int Id { get; set; }


        [Required]
        [StringLength(TitleMaxLength, MinimumLength = TitleMinLength)]
        public required string Title { get; set; }


        [Required]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength)]
        public required string Description { get; set; }
    }
}
