
using RoomieFinderInfrastructure.Models;

namespace RoomieFinderInfrastructure.SeedDb.Seeders
{
    public static class QualitySeeder
    {
        public static Quality QualityOne { get; set; } = new Quality()
        {
            Id = 1,
            Name = "Artistic"
        };

        public static Quality QualityTwo { get; set; } = new Quality()
        {
            Id = 2,
            Name = "Shy"
        };

        public static Quality QualityThree { get; set; } = new Quality()
        {
            Id = 3,
            Name = "Social"
        };
        public static Quality QualityFour { get; set; } = new Quality()
        {
            Id = 4,
            Name = "Video Gamer"
        };
        public static Quality QualityFive { get; set; } = new Quality()
        {
            Id = 5,
            Name = "Liberal"
        };
        public static Quality QualitySix { get; set; } = new Quality()
        {
            Id = 6,
            Name = "Conservative"
        };
        public static Quality QualitySeven { get; set; } = new Quality()
        {
            Id = 7,
            Name = "Music lover"
        };
        public static Quality QualityEigth { get; set; } = new Quality()
        {
            Id = 8,
            Name = "Bookworm"
        };
        public static Quality QualityNine { get; set; } = new Quality()
        {
            Id = 9,
            Name = "Adventurer"
        };
        public static Quality QualityTen { get; set; } = new Quality()
        {
            Id = 10,
            Name = "Studious"
        };
    }
}
