using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static RoomieFinderInfrastructure.Constants.ModelConstants.AnswerConstants;

namespace RoomieFinderInfrastructure.Models
{
    public class Answer
    {
        [Key]
        [Required]
        [Comment("The unique identifyer for an answer")]
        public int Id { get; set; }

        [Required]
        [MaxLength(ContentMaxLength)]
        [Comment("The content of the answer")]
        public required string Content { get; set; }

        public required Question Question { get; set; }

        [ForeignKey(nameof(Question))]
        public int QuestionId { get; set; }

        public IList<StudentAnswer> StudentAnswers { get; set; } = new List<StudentAnswer>();
    }
}