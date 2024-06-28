

using System.ComponentModel.DataAnnotations;

namespace RoomieFinderInfrastructure.Models
{
    public class BlacklistedToken
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        public required string Value{ get; set; }
    }
}
