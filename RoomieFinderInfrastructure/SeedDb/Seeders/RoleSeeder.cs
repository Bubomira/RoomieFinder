using Microsoft.AspNetCore.Identity;

namespace RoomieFinderInfrastructure.SeedDb.Seeders
{
    internal static class RoleSeeder
    {

        public static IdentityRole GreatAdmin { get; set; } = new IdentityRole()
        {
            Id = "1d9ae291-1067-4ec5-9f2b-ad0ea4bd8b0e",
            Name = "GreatAdmin",
            NormalizedName = "GREATADMIN"
        };


        public static IdentityRole Student { get; set; } = new IdentityRole()
        {
            Id = "7ed277c0-8163-466a-ad9b-942646c198c7",
            Name = "Student",
            NormalizedName = "STUDENT"
        };

    }
}
