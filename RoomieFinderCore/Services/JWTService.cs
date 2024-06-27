using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using RoomieFinderCore.Contracts;
using RoomieFinderInfrastructure.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace RoomieFinderCore.Services
{
    public class JWTService : IJWTSContract
    {
        private readonly IConfiguration _configuration;

        public JWTService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<string> GenerateJWT(ApplicationUser applicationUser, bool isAdmin)
        {
            var credentials = new List<Claim>()
            {
                new Claim(ClaimTypes.Email,applicationUser.Email?? ""),
                new Claim(ClaimTypes.NameIdentifier,applicationUser.Id),
                new Claim(ClaimTypes.Name,$"{applicationUser.FirstName} {applicationUser.LastName}"),
                new Claim("IsAdmin",isAdmin.ToString())
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"] ?? ""));

            var token = new JwtSecurityToken(
                expires: DateTime.Now.AddDays(1),
                claims: credentials,
                signingCredentials: new SigningCredentials(key, SecurityAlgorithms.HmacSha256)
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
