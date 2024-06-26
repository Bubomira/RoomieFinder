using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoomieFinderInfrastructure.SeedDb.Seeders;

namespace RoomieFinderInfrastructure.SeedDb.Configurations
{
    internal class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(RoleSeeder.GreatAdmin, RoleSeeder.Student);
        }
    }
}
