

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

        public Task<bool> ChecksIfRequestIsSubmittedByUserAsync(int requestId, string userId) =>
            _unitOfWork.GetAllAsReadOnlyAsync<Request>()
            .AnyAsync(r => r.Id == requestId && r.Student.ApplicationUserId == userId);

        public Task<bool> CheckIfThereIsAnotherUnArchivedRequestForUserAsync(string userId) =>
            _unitOfWork.GetAllAsReadOnlyAsync<Request>()
            .AnyAsync(r => r.Student.ApplicationUserId == userId);

        public Task<bool> ChecksIfTheRequestIsSubmittedByUserAndPendingAsync(int requestId, string userId) =>
              _unitOfWork.GetAllAsReadOnlyAsync<Request>()
              .AnyAsync(r => r.Id == requestId && r.Student.ApplicationUserId == userId && r.RequestStatus == RequestStatus.Pending);
    }
}
