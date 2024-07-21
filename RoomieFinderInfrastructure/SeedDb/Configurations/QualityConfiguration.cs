
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoomieFinderInfrastructure.Models;
using RoomieFinderInfrastructure.SeedDb.Seeders;

namespace RoomieFinderInfrastructure.SeedDb.Configurations
{
    public class QualityConfiguration : IEntityTypeConfiguration<Quality>
    {
        public void Configure(EntityTypeBuilder<Quality> builder)
        {
            builder.HasData([
                QualitySeeder.QualityOne,
                QualitySeeder.QualityTwo,
                QualitySeeder.QualityThree,
                QualitySeeder.QualityFour,
                QualitySeeder.QualityFive,
                QualitySeeder.QualitySix,
                QualitySeeder.QualitySeven,
                QualitySeeder.QualityEigth,
                QualitySeeder.QualityNine,
                QualitySeeder.QualityTen
                ]);
        }
    }
}
