
using System.ComponentModel.DataAnnotations;

namespace RoomieFinderCore.Dtos.UserDtos
{
    public class ChangePasswordDto
    {
        [Required]
        public required string Email { get; set; }

        [Required]
        public required string InitialPassword { get; set; }

        [Required]
        public required string NewPassword { get; set; }
    }
}
