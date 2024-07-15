using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoomieFinderInfrastructure.Models;
using RoomieFinderInfrastructure.SeedDb.Seeders;

namespace RoomieFinderInfrastructure.SeedDb.Configurations
{
    public class DormitoryConfiguration : IEntityTypeConfiguration<Dormitory>
    {
        public void Configure(EntityTypeBuilder<Dormitory> builder)
        {
            builder.HasData(DormitorySeeder.DormitoryOne, DormitorySeeder.DormitoryTwo);
        }
    }
}
