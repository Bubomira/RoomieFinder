

using RoomieFinderCore.Dtos.UserDtos;

namespace RoomieFinderCore.Contracts.AuthContracts
{
    public interface IAuthContract
    {
        public Task<string?> RegisterUserAsync(RegisterUserDto registerUserDto);
        public Task RegisterStudentAsync(string id, int yearAtUniversity);
        public Task<LoggedInUserDto?> LoginUserAsync(LoginUserDto loginUserDto);
        public Task ChangeInitialPasswordAsync(ChangePasswordDto changePasswordDto);

    }
}
