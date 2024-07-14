

using RoomieFinderCore.Dtos.UserDtos;

namespace RoomieFinderCore.Contracts.AuthContracts
{
    public interface IAuthContract
    {
        public Task<string?> RegisterUserAsync(RegisterUserDto registerUserDto);
        public Task RegisterStudentAsync(string id, int yearAtUniversity, bool isMale);
        public Task<LoggedInUserDto?> LoginUserAsync(LoginUserDto loginUserDto);
        public Task LogoutAsync(string token);
        public Task ChangeInitialPasswordAsync(ChangePasswordDto changePasswordDto);

    }
}
