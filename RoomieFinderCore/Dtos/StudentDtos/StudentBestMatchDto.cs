

using System.ComponentModel.DataAnnotations;

namespace RoomieFinderCore.Dtos.StudentDtos
{
    public class StudentBestMatchDto
    {
        [Required]
        public required string FullName { get; set; }
        [Required]
        public required int YearAtUniversity { get; set; }
        public bool HasAssignedRoom { get; set; }
        public int? AssignedRoomId { get;set; }
    }
}
