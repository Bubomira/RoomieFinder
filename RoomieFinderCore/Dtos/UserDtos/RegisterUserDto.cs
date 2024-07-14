
using System.ComponentModel.DataAnnotations;
using static RoomieFinderInfrastructure.Constants.ModelConstants.ApplicationUserConstants;
namespace RoomieFinderCore.Dtos.UserDtos
{
    public class RegisterUserDto
    {
        [Required]
        [StringLength(FirstNameMaxLength, MinimumLength = FirstNameMinLength)]
        public required string FirstName { get; set; }

        [Required]
        [StringLength(LastNameMaxLength, MinimumLength = LastNameMinLength)]
        public required string LastName { get; set; }

        [Required]
        [EmailAddress]
        public required string Email { get; set; }

        [Required]
        [StringLength(UsernameMaxLength, MinimumLength = UsernameMinLength)]
        public required string Username { get; set; }

        [Required]
        [StringLength(PasswordMaxLength, MinimumLength = PasswordMinLength)]
        public required string SetUpPassword { get; set; }

        [Required]
        [Range(1, 5)]
        public required int YearAtUniversity { get; set; }

        [Required]
        public required bool IsMale { get; set; }
    }
}
