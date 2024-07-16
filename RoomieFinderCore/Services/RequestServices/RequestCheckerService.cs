

using Microsoft.EntityFrameworkCore;
using RoomieFinderCore.Contracts.RequestContracts;
using RoomieFinderInfrastructure.Enums;
using RoomieFinderInfrastructure.Models;
using RoomieFinderInfrastructure.UnitOfWork;

namespace RoomieFinderCore.Services.RequestServices
{
    public class RequestCheckerService : IRequestCheckerContract
    {
        private readonly IUnitOfWork _unitOfWork;

        public RequestCheckerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Task<bool> CheckIfRequestExistsByIdAsync(int requestId) =>
            _unitOfWork.GetAllAsReadOnlyAsync<Request>()
            .AnyAsync(r => r.Id == requestId);

        public Task<bool> ChecksIfAPendingRequestIsSubmittedByUserAsync(int requestId, string userId) =>
            _unitOfWork.GetAllAsReadOnlyAsync<Request>()
            .AnyAsync(r => r.Id == requestId && r.Student.ApplicationUserId == userId && r.RequestStatus == RequestStatus.Pending);

        public Task<bool> CheckIfThereIsAnotherUnArchivedRequestOfTheSameTypeAsync(string userId, RequestType requestType) =>
            _unitOfWork.GetAllAsReadOnlyAsync<Request>()
            .AnyAsync(r => r.Student.ApplicationUserId == userId && r.RequestType == requestType && r.RequestStatus != RequestStatus.Archived);
    }
}
