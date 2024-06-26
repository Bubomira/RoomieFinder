

using RoomieFinderInfrastructure.Models;

namespace RoomieFinderInfrastructure.SeedDb.Seeders
{
    internal static class StudentSeeders
    {
        public static Student StudentOne { get; set; } = new Student()
        {
            StudentId=1,
            YearAtUniversity=1,
            HasGraduated=false,
            ApplicationUserId = ApplicationUserSeeder.ApplicationUserThree.Id
        };

        public static Student StudentTwo { get; set; } = new Student()
        {
            StudentId = 2,
            YearAtUniversity = 1,
            HasGraduated = false,
            ApplicationUserId = ApplicationUserSeeder.ApplicationUserFour.Id
        };

        public static Student StudentThree { get; set; } = new Student()
        {
            StudentId = 3,
            YearAtUniversity = 2,
            HasGraduated = false,
            ApplicationUserId = ApplicationUserSeeder.ApplicationUserFive.Id
        };

        public static Student StudentFour { get; set; } = new Student()
        {
            StudentId = 4,
            YearAtUniversity = 3,
            HasGraduated = false,
            ApplicationUserId = ApplicationUserSeeder.ApplicationUserSix.Id
        };
    }
}
