

using Microsoft.EntityFrameworkCore;
using RoomieFinderInfrastructure.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static RoomieFinderInfrastructure.Constants.ModelConstants.RequestConstants;

namespace RoomieFinderInfrastructure.Models
{
    [Comment("A request made by a student connected with rooms and roomates")]
    public class Request
    {
        [Key]
        [Required]
        [Comment("The unique identifyer for a request")]
        public int Id { get; set; }

        [Required]
        [Comment("Shows the the of the request- can be for a single room, sepcific/different roomate")]
        public RequestType RequestType { get; set; }

        [Required]
        [Comment("Shows the sttaus of the request- pending, archived, accepted or declined")]
        public RequestStatus RequestStatus { get; set; }

        [MaxLength(CommentMaxLength)]
        [Comment("Additional comment toward the request")]
        public string? Comment { get; set; }

        [Required]
        [ForeignKey(nameof(Student))]
        [Comment("the identifyer of the student who made the request")]
        public required int StudentId { get; set; }

        public Student Student { get; set; } = null!;
    }
}
