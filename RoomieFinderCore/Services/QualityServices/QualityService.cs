
using Microsoft.EntityFrameworkCore;
using RoomieFinderCore.Contracts.QualityContracts;
using RoomieFinderCore.Dtos.QualityDtos;
using RoomieFinderInfrastructure.Models;
using RoomieFinderInfrastructure.UnitOfWork;

namespace RoomieFinderCore.Services.QualityServices
{
    public class QualityService : IQualityContract
    {
        private readonly IUnitOfWork _unitOfWork;
        public QualityService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<List<QualityPreviewDto>> GetAllQualitiesAsync() =>
            _unitOfWork.GetAllAsReadOnlyAsync<Quality>()
            .Select(q => new QualityPreviewDto()
            {
                Id = q.Id,
                Name = q.Name
            })
            .ToListAsync();

        public async Task SaveQualitiesAsync(List<int> qualityIds, int studentId)
        {
            List<StudentQualities> studentQualitiesList = new List<StudentQualities>();

            qualityIds.ForEach(qualityId =>
            {
                StudentQualities studentQuality = new StudentQualities()
                {
                    QualityId = qualityId,
                    StudentId = studentId
                };

                studentQualitiesList.Add(studentQuality);
            });

            await _unitOfWork.AddManyAsync(studentQualitiesList);

            await _unitOfWork.SaveChangesAsync();
        }
        public Task<bool> CheckIfAllQaulitiyIdsAreValidAsync(List<int> qualityIds) =>
            _unitOfWork.GetAllAsReadOnlyAsync<Quality>()
            .AllAsync(q => qualityIds.Contains(q.Id));
    }
}
