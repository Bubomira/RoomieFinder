using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoomieFinderInfrastructure.Models;
using RoomieFinderInfrastructure.SeedDb.Seeders;


namespace RoomieFinderInfrastructure.SeedDb.Configurations
{
    internal class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasData(
                StudentSeeders.StudentOne,
                StudentSeeders.StudentTwo,
                StudentSeeders.StudentThree,
                StudentSeeders.StudentFour
                );
        }
    }
}
