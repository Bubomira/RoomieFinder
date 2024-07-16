using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using RoomieFinderInfrastructure.Models;
using RoomieFinderInfrastructure.SeedDb.Configurations;

namespace RoomieFinderInfrastructure.Data
{
    public class RoomieFinderDbContext : IdentityDbContext<ApplicationUser>
    {
        public RoomieFinderDbContext(DbContextOptions<RoomieFinderDbContext> options)
            : base(options)
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
        public DbSet<Request> Requests { get; set; }
        public DbSet<BlacklistedToken> BlacklistedTokens { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new StudentAnswerConfiguration());
            builder.ApplyConfiguration(new ApplicationUserConfiguration());
            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new UserRoleConfiguration());
            builder.ApplyConfiguration(new StudentConfiguration());

            builder.ApplyConfiguration(new DormitoryConfiguration());
            builder.ApplyConfiguration(new RoomConfiguration());

            base.OnModelCreating(builder);
        }

    }
}
