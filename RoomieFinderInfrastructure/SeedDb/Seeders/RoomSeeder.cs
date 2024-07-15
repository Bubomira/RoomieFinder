

using RoomieFinderInfrastructure.Enums;
using RoomieFinderInfrastructure.Models;

namespace RoomieFinderInfrastructure.SeedDb.Seeders
{
    public static class RoomSeeder
    {
        public static Room RoomOne = new Room()
        {
            Id = 1,
            DormitoryId = DormitorySeeder.DormitoryOne.Id,
            RoomType = RoomType.Duplex,
            RemainingCapacity = 2,
            RoomNumber = 101
        };
        public static Room RoomTwo = new Room()
        {
            Id = 2,
            DormitoryId = DormitorySeeder.DormitoryOne.Id,
            RoomType = RoomType.Duplex,
            RemainingCapacity = 2,
            RoomNumber = 102
        };
        public static Room RoomThree = new Room()
        {
            Id = 3,
            DormitoryId = DormitorySeeder.DormitoryOne.Id,
            RoomType = RoomType.Apartament,
            RemainingCapacity = 4,
            RoomNumber = 204
        };
        public static Room RoomFour = new Room()
        {
            Id = 4,
            DormitoryId = DormitorySeeder.DormitoryOne.Id,
            RoomType = RoomType.Apartament,
            RemainingCapacity = 4,
            RoomNumber = 205
        };
        public static Room RoomFive = new Room()
        {
            Id = 5,
            DormitoryId = DormitorySeeder.DormitoryOne.Id,
            RoomType = RoomType.Apartament,
            RemainingCapacity = 4,
            RoomNumber = 307
        };



        public static Room RoomSix = new Room()
        {
            Id = 6,
            DormitoryId = DormitorySeeder.DormitoryTwo.Id,
            RoomType = RoomType.Single,
            RemainingCapacity = 1,
            RoomNumber = 101
        };

        public static Room RoomSeven = new Room()
        {
            Id = 7,
            DormitoryId = DormitorySeeder.DormitoryTwo.Id,
            RoomType = RoomType.Single,
            RemainingCapacity = 1,
            RoomNumber = 102
        };

        public static Room RoomEigth = new Room()
        {
            Id = 8,
            DormitoryId = DormitorySeeder.DormitoryTwo.Id,
            RoomType = RoomType.Duplex,
            RemainingCapacity = 2,
            RoomNumber = 208
        };

        public static Room RoomNine = new Room()
        {
            Id = 9,
            DormitoryId = DormitorySeeder.DormitoryTwo.Id,
            RoomType = RoomType.Apartament,
            RemainingCapacity = 4,
            RoomNumber = 209
        };

        public static Room RoomTen = new Room()
        {
            Id = 10,
            DormitoryId = DormitorySeeder.DormitoryTwo.Id,
            RoomType = RoomType.Single,
            RemainingCapacity = 1,
            RoomNumber = 301
        };

        public static Room RoomEleven = new Room()
        {
            Id = 11,
            DormitoryId = DormitorySeeder.DormitoryTwo.Id,
            RoomType = RoomType.Single,
            RemainingCapacity = 1,
            RoomNumber = 302
        };


    }
}
