

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoomieFinderInfrastructure.Models
{
    [Comment("The users who is responsible for the tests and matching roomates")]
    public class UniversityAdmin:ApplicationUser
    {
        public required University University { get; set; }

        [Required]
        [ForeignKey(nameof(University))]
        public int UniversityId { get; set; }

    }
}
