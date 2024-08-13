

using System.ComponentModel.DataAnnotations;

namespace RoomieFinderCore.Dtos.RequestDtos
{
    public class RequestSearchPreviewDto:RequestPreviewDto
    {
        [Required]
        public required string RequesterEmail { get; set; } 
    }
}
