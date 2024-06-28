using RoomieFinderInfrastructure.Models;

namespace RoomieFinderCore.Contracts.AuthContracts
{
    public interface IJWTSContract
    {
        public Task<string> GenerateJWT(ApplicationUser applicationUser, bool isAdmin);
        public Task<bool> CheckIfTokenIsBlacklisted(string token);
    }

}
