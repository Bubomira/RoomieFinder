

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoomieFinderInfrastructure.Models;
using RoomieFinderInfrastructure.SeedDb.Seeders;

namespace RoomieFinderInfrastructure.SeedDb.Configurations
{
    public class AnswerSheetConfiguration : IEntityTypeConfiguration<AnswerSheet>
    {
        public void Configure(EntityTypeBuilder<AnswerSheet> builder)
        {
            builder.HasData([
                AnswerSheetSeeder.AnswerSheetOne,
                AnswerSheetSeeder.AnswerSheetTwo,
                AnswerSheetSeeder.AnswerSheetThree,
                AnswerSheetSeeder.AnswerSheetFour
                ]);
        }
    }
}
