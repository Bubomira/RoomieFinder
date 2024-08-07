

using RoomieFinderCore.Dtos.AnswerSheetDtos;
using System.ComponentModel.DataAnnotations;

namespace RoomieFinderCore.Dtos.StudentDtos
{
    public class StudentBestMatchDto:RoomateDto
    {

        public required AnswerSheetMetadataDto AnswersAsUser { get; set; }
        public bool HasAssignedRoom { get; set; }
        public int? AssignedRoomId { get; set; }
        public int? AssignedRoomNumber { get; set; }
        public string? AssignedDormitoryName { get; set; }
        public int? RoomCapacityLeft { get; set; }

        public IList<string> Qualities
            = new List<string>();
    }
}
