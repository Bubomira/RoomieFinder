
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoomieFinderInfrastructure.Models
{
    [Comment("The test which holds the roomate questions students need to fill out")]
    public class AnswerSheet
    {

        [Key]
        [Required]
        [Comment("The unique identifyer of each answersheet")]
        public int Id { get; set; }

        [Required]
        [Comment("Describes if an answer sheet can be filled out by students")]
        public required bool IsEditable { get; set; } = true;


        [Required]
        [Comment("Boolean value which shows if the student prefers a messy/tidy roomate")]
        public required bool IsMessy { get; set; }

        [Required]
        [Comment("Boolean value which shows the preferred room atmosphere")]
        public required bool IsIntrovert { get; set; }

        [Required]
        [Comment("Boolean value which depicts if the student goes to sleep early")]
        public required bool GoesToSleepEarly { get; set; }

        [Required]
        [Comment("Boolean value which depicts if the student prefers a quiet atmpshere")]
        public required bool LikesQuietness { get; set; }

        [Required]
        [Comment("Boolean value which depicts if the student prefers to wake up early")]
        public required bool WakesUpEarly { get; set; }

        [Required]
        [Comment("the identifyer of the student whose answers are this")]
        public required int StudentId { get; set; }

        [ForeignKey(nameof(StudentId))]
        public Student Student { get; set; } = null!;

    }
}
