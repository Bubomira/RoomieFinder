using RoomieFinderCore.Dtos.QualityDtos;

namespace RoomieFinderCore.Contracts.QualityContracts
{
    public interface IQualityContract
    {
        /// <summary>
        /// Saves the chosen by the current student qualities
        /// </summary>
        /// <param name="qualityIds"></param>
        /// <param name="studentId"></param>
        /// <returns></returns>
        public Task SaveQualitiesAsync(List<int> qualityIds, int studentId);

        /// <summary>
        /// Gets all available qualities
        /// </summary>
        /// <returns></returns>
        public Task<List<QualityPreviewDto>> GetAllQualitiesAsync();

        /// <summary>
        /// Checks if all of the submitted ids are valid
        /// </summary>
        /// <param name="qualityIds"></param>
        /// <returns></returns>
        public Task<bool> CheckIfAllQaulitiyIdsAreValidAsync(List<int> qualityIds);
    }
}
