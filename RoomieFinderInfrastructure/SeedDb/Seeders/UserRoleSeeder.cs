

using Microsoft.AspNetCore.Identity;
using RoomieFinderInfrastructure.Models;

namespace RoomieFinderInfrastructure.SeedDb.Seeders
{
    public static class UserRoleSeeder
    {

        public static IdentityUserRole<string> UserRoleOne { get; set; } = new IdentityUserRole<string>
        {
            RoleId = RoleSeeder.GreatAdmin.Id,
            UserId = ApplicationUserSeeder.ApplicationUserOne.Id
        };

        public static IdentityUserRole<string> UserRoleTwo { get; set; } = new IdentityUserRole<string>
        {
            RoleId = RoleSeeder.GreatAdmin.Id,
            UserId = ApplicationUserSeeder.ApplicationUserTwo.Id
        };

        public static IdentityUserRole<string> UserRoleThree { get; set; } = new IdentityUserRole<string>
        {
            RoleId = RoleSeeder.Student.Id,
            UserId = ApplicationUserSeeder.ApplicationUserThree.Id
        };

        public static IdentityUserRole<string> UserRoleFour { get; set; } = new IdentityUserRole<string>
        {
            RoleId = RoleSeeder.Student.Id,
            UserId = ApplicationUserSeeder.ApplicationUserFour.Id
        };

        public static IdentityUserRole<string> UserRoleFive { get; set; } = new IdentityUserRole<string>
        {
            RoleId = RoleSeeder.Student.Id,
            UserId = ApplicationUserSeeder.ApplicationUserFive.Id
        };

        public static IdentityUserRole<string> UserRoleSix { get; set; } = new IdentityUserRole<string>
        {
            RoleId = RoleSeeder.Student.Id,
            UserId = ApplicationUserSeeder.ApplicationUserSix.Id
        };
    }
}
