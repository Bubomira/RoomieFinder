﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RoomieFinderInfrastructure.Models
{
    public class Student
    {
        [Key]
        [Required]
        [Comment("The unique identifyer for each student")]
        public int StudentId { get; set; }
        [Required]
        [Comment("Year of attending the university")]
        public int YearAtUniversity { get; set; }

        [Required]
        [Comment("An indicator to the gender of a student")]
        public required bool IsMale { get; set; }

        [Required]
        [Comment("Shows if a student has graduated, graduated students cannot use the application")]
        public bool HasGraduated { get; set; }

        public Room? Room { get; set; }

        [ForeignKey(nameof(Room))]
        public int? RoomId { get; set; }

        public IList<StudentAnswer> StudentAnswers { get; set; } = new List<StudentAnswer>();

        public ApplicationUser ApplicationUser { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(ApplicationUser))]
        public required string ApplicationUserId { get; set; }
    }
}
