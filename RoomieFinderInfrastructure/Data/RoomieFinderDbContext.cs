using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using RoomieFinderInfrastructure.Models;


namespace RoomieFinderInfrastructure.Data
{
    public class RoomieFinderDbContext : IdentityDbContext<ApplicationUser>
    {
        public RoomieFinderDbContext(DbContextOptions<RoomieFinderDbContext> options)
            :base(options)
        {
            
        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Student> Students { get; set; }  
        public DbSet<Dormitory> Dormitories { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Questionnaire> Questionnaires { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<StudentAnswer> StudentsAnswers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //many-tomany relationship between student and asnwers
            builder.Entity<StudentAnswer>()
                .HasOne(sa => sa.Student)
                .WithMany(s => s.StudentAnswers)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(sa => sa.StudentId);

            builder.Entity<StudentAnswer>()
                .HasOne(sa => sa.Answer)
                .WithMany(s => s.StudentAnswers)
                .HasForeignKey(sa => sa.AnswerId);

            //configuring key for many-to-many student answer table
            builder.Entity<StudentAnswer>()
                .HasKey(sa => new { sa.AnswerId, sa.StudentId });

            base.OnModelCreating(builder);
        }

    }
}
