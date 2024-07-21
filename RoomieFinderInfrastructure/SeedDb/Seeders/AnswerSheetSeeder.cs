

using RoomieFinderInfrastructure.Models;

namespace RoomieFinderInfrastructure.SeedDb.Seeders
{
    public static class AnswerSheetSeeder
    {
        public static AnswerSheet AnswerSheetOne { get; set; } = new AnswerSheet()
        {
            Id = 1,
            GoesToSleepEarly = true,
            LikesQuietness = true,
            IsEditable = true,
            IsIntrovert = false,
            IsMessy = true,
            WakesUpEarly = false,
            StudentId = StudentSeeders.StudentOne.StudentId
        };

        public static AnswerSheet AnswerSheetTwo { get; set; } = new AnswerSheet()
        {
            Id = 2,
            GoesToSleepEarly = true,
            LikesQuietness = false,
            IsEditable = true,
            IsIntrovert = false,
            IsMessy = false,
            WakesUpEarly = true,
            StudentId = StudentSeeders.StudentTwo.StudentId
        };

        public static AnswerSheet AnswerSheetThree { get; set; } = new AnswerSheet()
        {
            Id = 3,
            GoesToSleepEarly = false,
            LikesQuietness = false,
            IsEditable = true,
            IsIntrovert = true,
            IsMessy = true,
            WakesUpEarly = false,
            StudentId = StudentSeeders.StudentThree.StudentId
        };

        public static AnswerSheet AnswerSheetFour { get; set; } = new AnswerSheet()
        {
            Id = 4,
            GoesToSleepEarly = false,
            LikesQuietness = false,
            IsEditable = true,
            IsIntrovert = false,
            IsMessy = true,
            WakesUpEarly = true,
            StudentId = StudentSeeders.StudentFour.StudentId
        };
    }
}
