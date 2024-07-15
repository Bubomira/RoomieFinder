
using RoomieFinderInfrastructure.Models;

namespace RoomieFinderInfrastructure.SeedDb.Seeders
{
    public static class DormitorySeeder
    {
        public static Dormitory DormitoryOne = new Dormitory()
        {
            Id = 1,
            Name = "First dormitory"
        };

        public static Dormitory DormitoryTwo = new Dormitory()
        {
            Id = 2,
            Name = "Second dormitory"
        };
    }
}
