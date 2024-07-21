

using System.ComponentModel.DataAnnotations;

namespace RoomieFinderCore.Dtos.QualityDtos
{
    public class QualityPreviewDto
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public required string Name { get; set; }
    }
}
