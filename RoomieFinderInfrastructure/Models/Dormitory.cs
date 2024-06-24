

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

using static RoomieFinderInfrastructure.Constants.ModelConstants.DormitoryConstants;

namespace RoomieFinderInfrastructure.Models
{
    [Comment("Dormitory is the place where students live")]
    public class Dormitory
    {
        [Key]
        [Required]
        [Comment("Unique identifyer of each dormitory")]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        [Comment("The name of the dormitory")]
        public required string Name { get; set; }

        public IList<Room> Rooms { get; set; } = new List<Room>();
    }
}
