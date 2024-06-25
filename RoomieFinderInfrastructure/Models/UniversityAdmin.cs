

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoomieFinderInfrastructure.Models
{
    [Comment("The users who is responsible for the tests and matching roomates")]
    public class UniversityAdmin
    {
        [Key]
        [Required]
        [Comment("The unique identifyer for each university admin")]
        public int UniversityAdminId { get; set; }

        public required University University { get; set; }

        [Required]
        [ForeignKey(nameof(University))]
        public int UniversityId { get; set; }

        public required ApplicationUser ApplicationUser { get; set; }

        [Required]
        [ForeignKey(nameof(ApplicationUser))]
        public required string ApplicationUserId { get; set; }

    }
}
