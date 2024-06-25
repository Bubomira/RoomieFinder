using Microsoft.EntityFrameworkCore;
using RoomieFinderInfrastructure.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoomieFinderInfrastructure.Models
{
    [Comment("Room in dormitory")]
    public class Room
    {
        [Key]
        [Required]
        [Comment("The unique identifyer of a room in the database")]
        public int Id { get; set; }

        [Required]
        [Comment("Room type, can be single, duplex, apartament")]
        public RoomType RoomType { get; set; }

        [Required]
        [Comment("The room number is its identifyer in the dormitory")]
        public int RoomNumber { get; set; }


        [ForeignKey(nameof(Dormitory))]
        public int DormitoryId { get; set; }
        public required Dormitory Dormitory { get; set; }

        public IList<Student> Students { get; set; } = new List<Student>();
    }
}