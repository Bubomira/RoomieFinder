
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

using static RoomieFinderInfrastructure.Constants.ModelConstants.UniversityConstants;

namespace RoomieFinderInfrastructure.Models
{
    [Comment("The university is where students go to study")]
    public class University
    {
        [Key]
        [Required]
        [Comment("The unique identifyer of each university")]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        [Comment("The name of the university")]
        public required string Name { get; set; }

        public IList<UniversityAdmin> UniversityAdmins { get; set; } = new List<UniversityAdmin>();
        public IList<Student> Students { get; set; } = new List<Student>();
        public IList<Dormitory> Dormitories { get; set; } = new List<Dormitory>();

    }
}
