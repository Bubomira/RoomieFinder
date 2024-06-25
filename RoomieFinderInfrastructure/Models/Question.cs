
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static RoomieFinderInfrastructure.Constants.ModelConstants.QuestionConstants;

namespace RoomieFinderInfrastructure.Models
{
    [Comment("Question from the test")]
    public class Question
    {
        [Key]
        [Required]
        [Comment("The unique identifyer of a question")]
        public int Id { get; set; }

        [Required]
        [MaxLength(TitleMaxLength)]
        [Comment("The title of the question")]
        public required string Content { get; set; }

        [Required]
        [Comment("The type of a question, can be radio or checkbox")]
        public required bool IsSingleAnswer { get; set; }

        public required Questionnaire Questionnaire { get; set; }
        [Required]
        [ForeignKey(nameof(Questionnaire))]
        public int QuestionnaireId { get; set; }


        public IList<Answer> Answer { get; set; } = new List<Answer>();

    }
}
