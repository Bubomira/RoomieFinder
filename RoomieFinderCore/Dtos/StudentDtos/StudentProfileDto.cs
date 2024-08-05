using RoomieFinderCore.Dtos.AnswerSheetDtos;
using RoomieFinderCore.Dtos.RequestDtos;
using System.ComponentModel.DataAnnotations;

namespace RoomieFinderCore.Dtos.StudentDtos
{
    public class StudentProfileDto
    {
        [Required]
        public required string Id { get; set; }

        [Required]
        public required string Fullname { get; set; }

        [Required]
        public required string UserName { get; set; }

        [Required]
        public required string Email { get; set; }

        public int YearAtUiversity { get; set; }
        public bool IsMale { get; set; }

        public AnswerSheetMetadataDto GeneralAnswers { get; set; }

        public IList<RoomateDto> Roomates { get; set; } =
            new List<RoomateDto>();

        public IList<RequestPreviewDto> Requests { get; set; } =
            new List<RequestPreviewDto>();

    }
}
