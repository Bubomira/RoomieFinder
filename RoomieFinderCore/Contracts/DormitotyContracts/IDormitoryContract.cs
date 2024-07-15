

using RoomieFinderCore.Dtos.DormitoryDtos;

namespace RoomieFinderCore.Contracts.DormitotyContracts
{
    public interface IDormitoryContract
    {
        /// <summary>
        /// Gets all of the available dormitories in the database
        /// </summary>
        /// <returns></returns>
        public Task<List<DormitoryPreviewDto>> GetAllDormitoriesAsync();
        /// <summary>
        /// Checks if a dormitory exists by given id
        /// </summary>
        /// <param name="dormitoryId"></param>
        /// <returns></returns>
        public Task<bool> CheckIfDormitoryExistsByIdAsync(int dormitoryId);
    }
}
