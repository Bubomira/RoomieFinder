

using System.ComponentModel.DataAnnotations;

using static RoomieFinderInfrastructure.Constants.ModelConstants.ApplicationUserConstants;

namespace RoomieFinderCore.Dtos.UserDtos
{
    public class LoginUserDto
    {
        [Required]
        [EmailAddress]
        public required string Email { get; set; }

        [Required]
        [StringLength(PasswordMaxLength,MinimumLength = PasswordMinLength)]
        public required string Password { get; set; }
    }
}
