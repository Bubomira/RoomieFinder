

using RoomieFinderInfrastructure.Enums;
using System.ComponentModel.DataAnnotations;

using static RoomieFinderInfrastructure.Constants.ModelConstants.RequestConstants;

namespace RoomieFinderCore.Dtos.RequestDtos
{
    public class RequestPostDto
    {
        [MaxLength(CommentMaxLength)]
        public string? Comment { get; set; }
        public RequestType RequestType { get; set; }
    }
}
