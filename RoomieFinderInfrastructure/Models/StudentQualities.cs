

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoomieFinderInfrastructure.Models
{
    [Comment("All of the student interests used to make better roomate matches")]
    public class StudentQualities
    {
        [Required]
        [ForeignKey(nameof(Student))]
        [Comment("The student id who has picked the interest, part of composite key")]
        public required int StudentId { get; set; }

        public Student Student { get; set; } = null!;

        public Quality Quality { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Quality))]
        [Comment("The interest id picked by the student, part of composite key")]
        public required int QualityId { get; set; }

    }
}
