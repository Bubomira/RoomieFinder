using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RoomieFinderCore.Contracts.AuthContracts;
using RoomieFinderCore.Dtos.UserDtos;

namespace RoomieFinderAPI.Areas
{
    [ApiController]
    [Route("auth")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthContract _authContract;

        public AuthenticationController(IAuthContract authContract)
        {
            _authContract = authContract;
        }

        [HttpPost("login")]
        [ProducesResponseType(200, Type = typeof(LoggedInUserDto))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> Login([FromBody] LoginUserDto loginUserDto)
        {
            if (ModelState.IsValid)
            {
                var loggedUser = await _authContract.LoginUserAsync(loginUserDto);
                if (loggedUser != null)
                {
                    return Ok(loggedUser);
                }
            }

            return BadRequest("Wrong login credentials!");
        }

        [HttpPost("register")]
        [Authorize(Roles = "GreatAdmin", AuthenticationSchemes = "Bearer")]
        [ProducesResponseType(200, Type = typeof(string))]
        [ProducesResponseType(400, Type = typeof(string))]
        public async Task<IActionResult> RegisterUser([FromBody] RegisterUserDto registerUserDto)
        {
            if (ModelState.IsValid)
            {
                var userId = await _authContract.RegisterUserAsync(registerUserDto);
                if (userId != null)
                {
                    await _authContract.RegisterStudentAsync(userId, registerUserDto.YearAtUniversity, registerUserDto.IsMale);
                    return Ok($"Successfully registered {registerUserDto.FirstName} {registerUserDto.LastName}");
                }
            }
            return BadRequest("Registration failed");
        }

        [HttpPost("password/change")]
        [Authorize(Roles = "Student", AuthenticationSchemes = "Bearer")]
        [ProducesResponseType(200, Type = typeof(string))]
        [ProducesResponseType(400, Type = typeof(string))]
        public async Task<IActionResult> ChangeInitialPassword([FromBody] ChangePasswordDto changePasswordDto)
        {
            if (ModelState.IsValid)
            {
                await _authContract.ChangeInitialPasswordAsync(changePasswordDto);
                return Ok("Successfully changed password!");

            }
            return BadRequest("Could not change password");
        }

        [HttpGet("logout")]
        [Authorize(AuthenticationSchemes ="Bearer")]
        [ProducesResponseType(204)]
        public async Task<IActionResult> Logout()
        {
            var token = Request.Headers.Authorization.ToString();
            if (token != null)
            {
                await _authContract.LogoutAsync(token);
            }
            return NoContent();
        }
    }
}
