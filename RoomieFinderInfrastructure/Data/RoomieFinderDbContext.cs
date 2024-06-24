using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using RoomieFinderInfrastructure.Models;


namespace RoomieFinderInfrastructure.Data
{
    public class RoomieFinderDbContext : IdentityDbContext<ApplicationUser>
    {
        public RoomieFinderDbContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<UniversityAdmin> UniversityAdmins { get; set; }
        public DbSet<University> Universities { get; set; }      
        public DbSet<Dormitory> Dormitories { get; set; }
        public DbSet<Room> Rooms { get; set; }

    }
}
