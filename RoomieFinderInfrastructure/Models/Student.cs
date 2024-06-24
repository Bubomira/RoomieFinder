using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RoomieFinderInfrastructure.Models
{
    public class Student:ApplicationUser
    {

        [Required]
        [Comment("Year of attending the university")]
        public int YearAtUniversity { get; set; }

        [Required]
        [Comment("Shows if a student has graduated, graduated students cannot use the application")]
        public bool HasGraduated { get; set; }     
        

        public required University University { get; set; }

        [ForeignKey(nameof(University))]
        public int UniversityId { get; set; }


        public required Room Room { get; set; }

        [ForeignKey(nameof(Room))]
        public int RoomId { get; set; }
    }
}
