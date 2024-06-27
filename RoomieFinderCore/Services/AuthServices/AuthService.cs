using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
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
                await _userManager.ChangePasswordAsync(user, changePasswordDto.InitialPassword, changePasswordDto.NewPassword);
            }
        }

        public async Task<string?> LoginUserAsync(LoginUserDto loginUserDto)
        {
            var user = await _userManager.FindByEmailAsync(loginUserDto.Email);
            if (user != null)
            {
                var result = await _signInManager.CheckPasswordSignInAsync(user, loginUserDto.Password, false);
                if (result.Succeeded)
                {
                    return await _jwtService.GenerateJWT(user, await _userManager.IsInRoleAsync(user, "GreatAdmin"));
                }
            }
            return null;
        }

        public async Task RegisterStudentAsync(string id, int yearAtUniversity)
        {
            Student student = new Student()
            {
                ApplicationUserId = id,
                HasGraduated = false,
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
                    NormalizedUserName = registerUserDto.Username.ToUpper()
                };

                await _userManager.CreateAsync(user, registerUserDto.SetUpPassword);

                await _unitOfWork.AddEntityAsync(user);
                await _unitOfWork.SaveChangesAsync();

                return user.Id;
            }
            return null;
        }
    }
}
