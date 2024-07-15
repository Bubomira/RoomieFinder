
namespace RoomieFinderCore.Dtos.StudentDtos
{
    public class RoomlessStudentsListDto
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

        public List<StudentWithoutARoomDto> StudentsWithoutARoom { get; set; }
           = new List<StudentWithoutARoomDto>();

    }
}
