

using RoomieFinderInfrastructure.Enums;

namespace RoomieFinderCore.Dtos.StudentDtos
{
    public class StudentSeachListDto : StudentListDto
    {
        public string? SearchTerm { get; set; }

        public AreGraduated AreGraduated { get; set; }
        public GenderPreference GenderPreference { get; set; }
    }
}
