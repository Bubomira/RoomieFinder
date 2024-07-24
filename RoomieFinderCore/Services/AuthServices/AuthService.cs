using Microsoft.AspNetCore.Identity;
using RoomieFinderCore.Contracts.AuthContracts;
using RoomieFinderCore.Dtos.UserDtos;
using RoomieFinderInfrastructure.Models;
using RoomieFinderInfrastructure.UnitOfWork;

namespace RoomieFinderCore.Services.AuthServices
{
    public class AuthService : IAuthContract
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IJWTSContract _jwtService;
        private readonly IUnitOfWork _unitOfWork;

        public AuthService(
            SignInManager<ApplicationUser> signInManager,
            UserManager<ApplicationUser> userManager,
            IJWTSContract jwtService,
            IUnitOfWork unitOfWork
            )
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _jwtService = jwtService;
            _unitOfWork = unitOfWork;
        }
        public async Task ChangeInitialPasswordAsync(ChangePasswordDto changePasswordDto)
        {
            var user = await _userManager.FindByEmailAsync(changePasswordDto.Email);
            if (user != null && (await _signInManager.CheckPasswordSignInAsync(user, changePasswordDto.InitialPassword, false)).Succeeded)
            {
                var result = await _userManager.ChangePasswordAsync(user, changePasswordDto.InitialPassword, changePasswordDto.NewPassword);

                if (result.Succeeded)
                {
                    user.HasChangedPassword = true;
                    await _userManager.UpdateAsync(user);
                    return;
                }
            }
            throw new InvalidDataException("Incorrect credentials");

        }

        public async Task<LoggedInUserDto?> LoginUserAsync(LoginUserDto loginUserDto)
        {
            var user = await _userManager.FindByEmailAsync(loginUserDto.Email);
            if (user != null)
            {
                var result = await _signInManager.CheckPasswordSignInAsync(user, loginUserDto.Password, false);
                if (result.Succeeded)
                {
                    var isAdmin = await _userManager.IsInRoleAsync(user, "GreatAdmin");
                    return new LoggedInUserDto()
                    {
                        FullName = $"{user.FirstName} {user.LastName}",
                        HasChangedPassword = user.HasChangedPassword,
                        Id = user.Id,
                        IsAdmin = isAdmin,
                        HasFilledOutAnswerhseet = user.Student?.AnswerSheet != null,
                        Token = await _jwtService.GenerateJWT(user, isAdmin)
                    };
                }
            }
            return null;
        }

        public async Task RegisterStudentAsync(string id, int yearAtUniversity, bool isMale)
        {
            Student student = new Student()
            {
                ApplicationUserId = id,
                HasGraduated = false,
                IsMale = isMale,
                YearAtUniversity = yearAtUniversity
            };

            await _unitOfWork.AddEntityAsync(student);

            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<string?> RegisterUserAsync(RegisterUserDto registerUserDto)
        {
            if (await _userManager.FindByEmailAsync(registerUserDto.Email) == null)
            {
                var user = new ApplicationUser()
                {
                    FirstName = registerUserDto.FirstName,
                    LastName = registerUserDto.LastName,
                    Email = registerUserDto.Email,
                    NormalizedEmail = registerUserDto.Email.ToUpper(),
                    UserName = registerUserDto.Username,
                    NormalizedUserName = registerUserDto.Username.ToUpper(),
                    HasChangedPassword = false
                };

                await _userManager.CreateAsync(user, registerUserDto.SetUpPassword);

                await _unitOfWork.AddEntityAsync(user);
                await _unitOfWork.SaveChangesAsync();

                return user.Id;
            }
            return null;
        }

        public async Task LogoutAsync(string token)
        {
            BlacklistedToken blacklistedToken = new BlacklistedToken() { Value = token };

            await _unitOfWork.AddEntityAsync(blacklistedToken);
            await _unitOfWork.SaveChangesAsync();

            await _signInManager.SignOutAsync();
        }
    }
}
