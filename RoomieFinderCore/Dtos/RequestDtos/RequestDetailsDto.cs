

namespace RoomieFinderCore.Dtos.RequestDtos
{
    public class RequestDetailsDto : RequestSearchPreviewDto
    {
        public string? Comment { get; set; }

        public required string RequesterFullName { get; set; }
        public required string RequesterUserId { get; set; }
    }
}
