using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static RoomieFinderInfrastructure.Constants.ModelConstants.QualityConstants;

namespace RoomieFinderInfrastructure.Models
{
    public class Quality
    {
        [Key]
        [Required]
        [Comment("The unique identifyer for a quality")]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        [Comment("Name of quality")]
        public required string Name { get; set; }

        public IList<StudentQualities> StudentsQualities { get; set; } = new List<StudentQualities>();
    }
}