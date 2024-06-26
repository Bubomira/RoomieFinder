using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoomieFinderInfrastructure.Models;


namespace RoomieFinderInfrastructure.SeedDb.Configurations
{
    internal class StudentAnswerConfiguration : IEntityTypeConfiguration<StudentAnswer>
    {
        public void Configure(EntityTypeBuilder<StudentAnswer> builder)
        {
            //many-tomany relationship between student and asnwers
            builder
                .HasOne(sa => sa.Student)
                .WithMany(s => s.StudentAnswers)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(sa => sa.StudentId);

            builder
                .HasOne(sa => sa.Answer)
                .WithMany(s => s.StudentAnswers)
                .HasForeignKey(sa => sa.AnswerId);

            //configuring key for many-to-many student answer table
            builder.HasKey(sa => new { sa.AnswerId, sa.StudentId });
        }
    }
}
