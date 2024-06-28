
using Microsoft.AspNetCore.Identity;
using RoomieFinderInfrastructure.Models;

namespace RoomieFinderInfrastructure.SeedDb.Seeders
{
    public class ApplicationUserSeeder
    {

        public static ApplicationUser ApplicationUserOne { get; set; } = new ApplicationUser()
        {
            Id = "77cc9efa-570e-464c-a3c3-805a1cf94b30",
            FirstName = "Sofia University",
            LastName = "Admin",
            Email = "sofia_university_admin@gmail.com",
            NormalizedEmail="SOFIA_UNIVERSITY_ADMIN@GMAIL.COM",
            UserName = "Sofia University Admin",
            NormalizedUserName="SOFIA UNIVERSITY ADMIN",
            HasChangedPassword=true
        };

        public static ApplicationUser ApplicationUserTwo { get; set; } = new ApplicationUser()
        {
            Id = "169f682a-e6d0-4aca-8b74-d51dbcaa58ef",
            FirstName = "Medical University",
            LastName = "Admin",
            Email = "medical_university_admin@gmail.com",
            NormalizedEmail="MEDICAL_UNIVERSITY_ADMIN@GMAIL.COM",
            UserName = "Medical University Admin",
            NormalizedUserName = "MEDICAL UNIVERSITY ADMIN",
            HasChangedPassword = true
        };

        public static ApplicationUser ApplicationUserThree { get; set; } = new ApplicationUser()
        {
            Id = "51d96dfa-943a-44a3-a39b-136844852055",
            FirstName = "Alisa",
            LastName = "Markova",
            Email = "alisa_markova@gmail.com",
            NormalizedEmail="ALISA_MARKOVA@GMAIL.COM",
            UserName = "Alise_Marie",
            NormalizedUserName = "ALISE_MARIE",
            HasChangedPassword = true
        };
        public static ApplicationUser ApplicationUserFour { get; set; } = new ApplicationUser()
        {
            Id = "88273e30-0ad0-4095-b288-51f0d4f2eba0",
            FirstName = "Nikolay",
            LastName = "Georgiev",
            Email = "niki_g@gmail.com",
            NormalizedEmail = "NIKI_G@GMAIL.COM",
            UserName = "Nikk",
            NormalizedUserName = "NIKK",
            HasChangedPassword = true
        };

        public static ApplicationUser ApplicationUserFive { get; set; } = new ApplicationUser()
        {
            Id = "47ca66e3-a4b0-43ca-916a-edf44842f9f7",
            FirstName = "Marina",
            LastName = "Nikolova",
            Email = "marina_nikolova.56@gmail.com",
            NormalizedEmail = "MARINA_NIKOLOVA@GMAIL.COM",
            UserName = "Marina_",
            NormalizedUserName = "MARINA_",
            HasChangedPassword = true
        };

        public static ApplicationUser ApplicationUserSix { get; set; } = new ApplicationUser()
        {
            Id = "cc3beb38-92d0-44b9-9470-d24ffe951850",
            FirstName = "Petar",
            LastName = "Petrov",
            Email = "pepi_p@gmail.com",
            NormalizedEmail = "PEPI_P@GMAIL.COM",
            UserName = "_Pepi",
            NormalizedUserName = "_PEPI",
            HasChangedPassword = true
        };

        public static void HashPasswords()
        {

            PasswordHasher<ApplicationUser> _hasher = new PasswordHasher<ApplicationUser>();

            ApplicationUserOne.PasswordHash = _hasher.HashPassword(ApplicationUserOne, "12345678a");
            ApplicationUserTwo.PasswordHash = _hasher.HashPassword(ApplicationUserTwo, "12345678a");
            ApplicationUserThree.PasswordHash = _hasher.HashPassword(ApplicationUserThree, "12345678a");
            ApplicationUserFour.PasswordHash = _hasher.HashPassword(ApplicationUserFour, "12345678a");
            ApplicationUserFive.PasswordHash = _hasher.HashPassword(ApplicationUserFive, "12345678a");
            ApplicationUserSix.PasswordHash = _hasher.HashPassword(ApplicationUserSix, "12345678a");
        }


    }
}
