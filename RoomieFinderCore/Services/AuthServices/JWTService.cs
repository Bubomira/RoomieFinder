using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using RoomieFinderCore.Contracts.AuthContracts;
using RoomieFinderInfrastructure.Models;
using RoomieFinderInfrastructure.UnitOfWork;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace RoomieFinderCore.Services.AuthServices
{
    public class JWTService : IJWTSContract
    {
        private readonly IConfiguration _configuration;
        private readonly IUnitOfWork _unitOfWork;

        public JWTService(IConfiguration configuration, IUnitOfWork unitOfWork)
        {
            _configuration = configuration;
            _unitOfWork = unitOfWork;
        }
        public async Task<string> GenerateJWT(ApplicationUser applicationUser, bool isAdmin)
        {
            var credentials = new List<Claim>()
            {
                new Claim(ClaimTypes.Email,applicationUser.Email?? ""),
                new Claim(ClaimTypes.NameIdentifier,applicationUser.Id),
                new Claim("hasChangedPassword",applicationUser.HasChangedPassword.ToString()),
                new Claim(ClaimTypes.Name,$"{applicationUser.FirstName} {applicationUser.LastName}"),
                new Claim(ClaimTypes.Role,isAdmin? "GreatAdmin":"Student")
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"] ?? ""));

            var token = new JwtSecurityToken(
                expires: DateTime.Now.AddDays(1),
                claims: credentials,
                signingCredentials: new SigningCredentials(key, SecurityAlgorithms.HmacSha256)
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public Task<bool> CheckIfTokenIsBlacklisted(string token) =>
            _unitOfWork.GetAllAsReadOnlyAsync<BlacklistedToken>()
            .AnyAsync(bl => bl.Value == token);

    }
}
