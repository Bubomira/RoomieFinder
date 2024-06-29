
using RoomieFinderCore.Dtos.AnswerDtos;
using System.ComponentModel.DataAnnotations;

using static RoomieFinderInfrastructure.Constants.ModelConstants.QuestionConstants;

namespace RoomieFinderCore.Dtos.QuestionDtos
{
    public class QuestionDetailsDto
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(TitleMaxLength, MinimumLength = TitleMinLength)]
        public required string Content { get; set; }

        [Required]
        public required bool IsSingleAnswer { get; set; }

        public List<AnswerDetailsDto> Answers { get; set; }
          = new List<AnswerDetailsDto>();
    }
}
