using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

using static RoomieFinderInfrastructure.Constants.ModelConstants.ApplicationUserConstants;

namespace RoomieFinderInfrastructure.Models
{
    [Comment("The user of the application")]
    public class ApplicationUser:IdentityUser
    {
        [Required]
        [MaxLength(FirstNameMaxLength)]
        [Comment("The first name of each user")]
        public required string FirstName { get; set; }

        [Required] 
        [MaxLength(LastNameMaxLength)]
        [Comment("The last name of a user")]
        public required string LastName { get; set; }

    }
}
