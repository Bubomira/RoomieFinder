

using RoomieFinderCore.Dtos.DormitoryDtos;

namespace RoomieFinderCore.Contracts.DormitotyContracts
{
    public interface IDormitoryContract
    {
        public Task<List<DormitoryPreviewDto>> GetAllDormitoriesAsync();
        public Task<bool> CheckIfDormitoryExistsByIdAsync(int dormitoryId);
    }
}
