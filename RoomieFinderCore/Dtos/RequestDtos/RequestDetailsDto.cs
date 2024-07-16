

namespace RoomieFinderCore.Dtos.RequestDtos
{
    public class RequestDetailsDto : RequestPreviewDto
    {
        public string? Comment { get; set; }

        public required string RequesterFullName { get; set; }
        public required string RequesterUserId { get; set; }
    }
}
