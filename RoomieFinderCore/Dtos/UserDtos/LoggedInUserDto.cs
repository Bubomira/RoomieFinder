

namespace RoomieFinderCore.Dtos.UserDtos
{
    public class LoggedInUserDto
    {
        public required string Id { get; set; }
        public required string Token { get; set; }
        public required string FullName { get; set; }
        public required bool HasChangedPassword { get; set; }
        public required bool IsAdmin { get; set; }
        public required bool HasFilledOutAnswerhseet { get; set; }
    }
}
