
using RoomieFinderInfrastructure.Models;

namespace RoomieFinderCore.Contracts
{
    public interface IJWTSContract
    {
        public Task<string> GenerateJWT(ApplicationUser applicationUser, bool isAdmin);
    }

}
