

using RoomieFinderCore.Dtos.AnswerSheetDtos;
using System.ComponentModel.DataAnnotations;

namespace RoomieFinderCore.Dtos.StudentDtos
{
    public class StudentBestMatchDto
    {
        [Required]
        public required string FullName { get; set; }
        [Required]
        public required int YearAtUniversity { get; set; }

        public required AnswerSheetMetadataDto AnswerSheetMetadataDto { get; set; }
        public bool HasAssignedRoom { get; set; }
        public int? AssignedRoomId { get; set; }
        public int? AssignedRoomNumber { get; set; }
        public string? AssignedDormitoryName { get; set; }
        public int? RoomCapacityLeft { get; set; }

        public IList<string> Qualities
            = new List<string>();
    }
}
