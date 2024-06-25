﻿
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static RoomieFinderInfrastructure.Constants.ModelConstants.QuestionnaireConstants;

namespace RoomieFinderInfrastructure.Models
{
    [Comment("The test which holds the roomate questions students need to fill out")]
    public class Questionnaire
    {
        [Key]
        [Required]
        [Comment("The unique identifyer of each questionnaire")]
        public int Id { get; set; }

        [Required]
        [MaxLength(TitleMaxLength)]
        [Comment("The title of a questionaire")]
        public required string Title { get; set; }



        [Required]
        [MaxLength(DescriptionMaxLength)]
        [Comment("Description of the questionnaire, gives aditional info")]
        public required string Description { get; set; }


        public required University University { get; set; }
        [Required]
        [ForeignKey(nameof(University))]
        [Comment("Foreign key referencing table university")]
        public int UniversityId { get; set; }


        public IList<Question> Questions { get; set; } = new List<Question>();

    }
}