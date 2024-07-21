

using System.ComponentModel.DataAnnotations;

namespace RoomieFinderCore.Dtos.AnswerSheetDtos
{
    public class AnswerSheetMetadataDto
    {
        [Required]
        public required bool IsMessy { get; set; }

        [Required]
        public required bool IsIntrovert { get; set; }

        [Required]
        public required bool GoesToSleepEarly { get; set; }

        [Required]
        public required bool LikesQuietness { get; set; }

        [Required]
        public required bool WakesUpEarly { get; set; }
    }
}
