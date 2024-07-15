

using RoomieFinderInfrastructure.Enums;

namespace RoomieFinderCore.Dtos.RoomDtos
{
    public class RoomDetailsDto
    {
        public int Id { get; set; }
        public int RoomNumber { get; set; }
        public RoomType RoomType { get; set; }
        public int RemainingCapacity { get; set; }
    }
}
