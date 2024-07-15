

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoomieFinderInfrastructure.Models;
using RoomieFinderInfrastructure.SeedDb.Seeders;

namespace RoomieFinderInfrastructure.SeedDb.Configurations
{
    public class RoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.HasData(
                RoomSeeder.RoomOne,
                RoomSeeder.RoomTwo,
                RoomSeeder.RoomThree,
                RoomSeeder.RoomFour,
                RoomSeeder.RoomFive,
                RoomSeeder.RoomSix,
                RoomSeeder.RoomSeven,
                RoomSeeder.RoomEigth,
                RoomSeeder.RoomNine,
                RoomSeeder.RoomTen,
                RoomSeeder.RoomEleven
                );
        }
    }
}
