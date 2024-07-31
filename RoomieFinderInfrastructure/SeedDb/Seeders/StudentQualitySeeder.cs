
using RoomieFinderInfrastructure.Models;

namespace RoomieFinderInfrastructure.SeedDb.Seeders
{
    public static class StudentQualitySeeder
    {
        public static StudentQualities StudentQualityOne { get; set; } = new StudentQualities()
        {
            QualityId = QualitySeeder.QualityOne.Id,
            StudentId = StudentSeeders.StudentOne.StudentId
        };

        public static StudentQualities StudentQualityTwo { get; set; } = new StudentQualities()
        {
            QualityId = QualitySeeder.QualityThree.Id,
            StudentId = StudentSeeders.StudentOne.StudentId
        };
        public static StudentQualities StudentQualityThree { get; set; } = new StudentQualities()
        {
            QualityId = QualitySeeder.QualityEigth.Id,
            StudentId = StudentSeeders.StudentOne.StudentId
        };


        public static StudentQualities StudentQualityFour { get; set; } = new StudentQualities()
        {
            QualityId = QualitySeeder.QualityTwo.Id,
            StudentId = StudentSeeders.StudentTwo.StudentId
        };
        public static StudentQualities StudentQualityFive { get; set; } = new StudentQualities()
        {
            QualityId = QualitySeeder.QualityFive.Id,
            StudentId = StudentSeeders.StudentTwo.StudentId
        };
        public static StudentQualities StudentQualitySix { get; set; } = new StudentQualities()
        {
            QualityId = QualitySeeder.QualityNine.Id,
            StudentId = StudentSeeders.StudentTwo.StudentId
        };


        public static StudentQualities StudentQualitySeven { get; set; } = new StudentQualities()
        {
            QualityId = QualitySeeder.QualityOne.Id,
            StudentId = StudentSeeders.StudentThree.StudentId
        };
        public static StudentQualities StudentQualityEigth { get; set; } = new StudentQualities()
        {
            QualityId = QualitySeeder.QualityTwo.Id,
            StudentId = StudentSeeders.StudentThree.StudentId
        };
        public static StudentQualities StudentQualityNine { get; set; } = new StudentQualities()
        {
            QualityId = QualitySeeder.QualityFive.Id,
            StudentId = StudentSeeders.StudentThree.StudentId
        };

        public static StudentQualities StudentQualityTen { get; set; } = new StudentQualities()
        {
            QualityId = QualitySeeder.QualityFive.Id,
            StudentId = StudentSeeders.StudentFour.StudentId
        };
        public static StudentQualities StudentQualityEleven { get; set; } = new StudentQualities()
        {
            QualityId = QualitySeeder.QualityTen.Id,
            StudentId = StudentSeeders.StudentFour.StudentId
        };
        public static StudentQualities StudentQualityTwlevle { get; set; } = new StudentQualities()
        {
            QualityId = QualitySeeder.QualityEigth.Id,
            StudentId = StudentSeeders.StudentFour.StudentId
        };
    }
}
