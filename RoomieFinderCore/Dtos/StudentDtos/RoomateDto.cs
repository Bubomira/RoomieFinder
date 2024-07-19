

using System.ComponentModel.DataAnnotations;

namespace RoomieFinderCore.Dtos.StudentDtos
{
    public class RoomateDto
    {
        [Required]
        public required string Id { get; set; }
        public int YearAtUniversity { get; set; }
        [Required]
        public required string FullName { get; set; }
    }
}
