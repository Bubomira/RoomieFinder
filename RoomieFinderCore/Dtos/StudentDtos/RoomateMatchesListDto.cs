

using RoomieFinderCore.Dtos.AnswerSheetDtos;

namespace RoomieFinderCore.Dtos.StudentDtos
{
    public class RoomateMatchesListDto
    {
        private int pageNumber;

        public const int MaxItemsOnRoomatePage = 6;
        public RoomateMatchesListDto(int _pageNumber,string userId)
        {
            PageNumber = _pageNumber;
            UserId=userId;
        }

        public int PageNumber
        {
            get => pageNumber; set
            {
                if (value <= 0)
                {
                    throw new FormatException();
                }
                pageNumber = value;
            }
        }
        public bool IsMale { get; set; }
        public string UserId { get; set; }

        public int? UserAssignedRoomId { get; set; }

        public int TotalCount { get; set; }
        public List<StudentBestMatchDto> BestMatches { get; set; }
            = new List<StudentBestMatchDto>();
    }
}
