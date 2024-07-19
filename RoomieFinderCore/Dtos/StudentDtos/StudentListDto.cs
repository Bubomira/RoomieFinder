
namespace RoomieFinderCore.Dtos.StudentDtos
{
    public class StudentListDto
    {
        private int pageNumber;
        public const int StudentsOnPage = 12;

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

        public int TotalCount { get; set; }

        public List<StudentPreviewDto> Students { get; set; }
           = new List<StudentPreviewDto>();

    }
}
