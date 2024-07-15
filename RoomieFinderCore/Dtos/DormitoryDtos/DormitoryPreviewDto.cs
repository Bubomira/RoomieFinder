

using System.ComponentModel.DataAnnotations;

namespace RoomieFinderCore.Dtos.DormitoryDtos
{
    public class DormitoryPreviewDto
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public required string Name { get; set; }
    }
}
