using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoomieFinderInfrastructure.SeedDb.Seeders;

namespace RoomieFinderInfrastructure.SeedDb.Configurations
{
    internal class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                UserRoleSeeder.UserRoleOne,
                UserRoleSeeder.UserRoleTwo,
                UserRoleSeeder.UserRoleThree,
                UserRoleSeeder.UserRoleFour,
                UserRoleSeeder.UserRoleFive,
                UserRoleSeeder.UserRoleSix
             );
        }
    }
}
