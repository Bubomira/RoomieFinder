
using RoomieFinderInfrastructure.Enums;

namespace RoomieFinderCore.Dtos.RequestDtos
{
    public class RequestListDto
    {
        private int currentPage;

        public const int MaxItemsOnPage = 20;
        public int CurrentPage
        {
            get => currentPage; set
            {
                if (value <= 0)
                {
                    throw new FormatException();
                }
                currentPage = value;
            }
        }
        public RequestType PrefferedRequestType { get; set; } = RequestType.DoesntMatter;
        public RequestStatus PrefferedRequestStatus { get; set; } = RequestStatus.DoesntMatter;
        public int TotalCount { get; set; }

        public List<RequestSearchPreviewDto> Requests { get; set; }
           = new List<RequestSearchPreviewDto>();
    }
}
