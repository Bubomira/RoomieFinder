

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoomieFinderInfrastructure.Models;
using RoomieFinderInfrastructure.SeedDb.Seeders;

namespace RoomieFinderInfrastructure.SeedDb.Configurations
{
    internal class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            ApplicationUserSeeder.HashPasswords();
            builder.HasData(
                ApplicationUserSeeder.ApplicationUserOne,
                ApplicationUserSeeder.ApplicationUserTwo,
                ApplicationUserSeeder.ApplicationUserThree,
                ApplicationUserSeeder.ApplicationUserFour,
                ApplicationUserSeeder.ApplicationUserFive,
                ApplicationUserSeeder.ApplicationUserSix);
        }
    }
}
