

using System.ComponentModel.DataAnnotations;

namespace RoomieFinderCore.Dtos.AnswerSheetDtos
{
    public class AnswerSheetMetadataDto
    {
        public bool IsMessy { get; set; }

        public bool IsIntrovert { get; set; }

        public bool GoesToSleepEarly { get; set; }
        public bool LikesQuietness { get; set; }

        public bool WakesUpEarly { get; set; }

        [Required]
        public required bool IsFilledOut { get; set; }
    }
}
