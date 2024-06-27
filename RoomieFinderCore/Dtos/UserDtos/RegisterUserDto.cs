
namespace RoomieFinderCore.Dtos.UserDtos
{
    public class RegisterUserDto
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public required string Username { get; set; }
        public required string SetUpPassword { get; set; }
        public required int YearAtUniversity { get; set; }
    }
}
