

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoomieFinderInfrastructure.Models
{
    [Comment("All of the student answers to the questionnaire")]
    public class StudentAnswer
    {
        [Required]
        [ForeignKey(nameof(Student))]
        [Comment("The student id who has picked the answer, part of composite key")]
        public required int StudentId { get; set; }

        public Student Student { get; set; } = null!;

        public Answer Answer { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Answer))]
        [Comment("The answer id picked by the student, part of composite key")]
        public required int AnswerId { get; set; }

    }
}
