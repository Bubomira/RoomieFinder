

namespace RoomieFinderCore.Dtos.RequestDtos
{
    public class RequestDetailsDto : RequestSearchPreviewDto
    {
        public string? Comment { get; set; }

        public bool CanBeAccepted { get; set; } = false;

        public required string RequesterFullName { get; set; }
        public required string RequesterUserId { get; set; }
    }
}
