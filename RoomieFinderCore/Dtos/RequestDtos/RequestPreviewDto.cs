using RoomieFinderInfrastructure.Enums;
using System.ComponentModel.DataAnnotations;

namespace RoomieFinderCore.Dtos.RequestDtos
{
    public class RequestPreviewDto
    {
        [Required]
        public int Id { get; set; }

        public RequestType RequestType { get; set; }
        public RequestStatus RequestStatus { get; set; }
    }
}
