

using Microsoft.EntityFrameworkCore;
using RoomieFinderCore.Contracts.DormitotyContracts;
using RoomieFinderCore.Dtos.DormitoryDtos;
using RoomieFinderInfrastructure.Models;
using RoomieFinderInfrastructure.UnitOfWork;

namespace RoomieFinderCore.Services.DormitoryServices
{
    public class DormitoryService : IDormitoryContract
    {
        private readonly IUnitOfWork _unitOfWork;

        public DormitoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Task<List<DormitoryPreviewDto>> GetAllDormitoriesAsync() =>
            _unitOfWork.GetAllAsReadOnlyAsync<Dormitory>()
            .Select(d => new DormitoryPreviewDto()
            {
                Id = d.Id,
                Name = d.Name
            })
            .ToListAsync();

        public Task<bool> CheckIfDormitoryExistsByIdAsync(int dormitoryId) =>
            _unitOfWork.GetAllAsReadOnlyAsync<Dormitory>()
            .AnyAsync(d => d.Id == dormitoryId);

    }
}
