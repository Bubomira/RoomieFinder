using Microsoft.EntityFrameworkCore;
using RoomieFinderCore.Contracts.RequestContracts;
using RoomieFinderInfrastructure.Enums;
using RoomieFinderInfrastructure.Models;
using RoomieFinderInfrastructure.UnitOfWork;

namespace RoomieFinderCore.Services.RequestServices
{
    public class RequestStatusService : IRequestStatusContract
    {
        private readonly IUnitOfWork _unitOtWork;

        public RequestStatusService(IUnitOfWork unitOfWork)
        {
            _unitOtWork = unitOfWork;
        }
        public async Task ChangeRequestStatusAsync(int requestId, RequestStatus requestStatus) =>
           await _unitOtWork.GetAllAsync<Request>()
            .Where(r => r.Id == requestId)
            .ExecuteUpdateAsync(setter => setter.SetProperty(r => r.RequestStatus, requestStatus));

        public async Task ArchiveAllRequestsAsync() =>
            await _unitOtWork.GetAllAsync<Request>()
            .Where(r => r.RequestStatus != RequestStatus.Archived)
            .ExecuteUpdateAsync(setter => setter.SetProperty(r => r.RequestStatus, RequestStatus.Archived));



        public async Task<List<RequestType>> GetPossibleRequestTypesAsync(string userId)
        {
            var possibleRequestTypes = new List<RequestType>() { RequestType.SingleRoom, RequestType.ChangeRoom, RequestType.SpecificRoomate };


            var currentRequestsTypes = await _unitOtWork.GetAllAsReadOnlyAsync<Request>()
                .Where(r => r.Student.ApplicationUserId == userId && r.RequestStatus != RequestStatus.Archived)
                .Select(r => r.RequestType)
                .ToListAsync();

            return possibleRequestTypes.Where(prt => currentRequestsTypes.Contains(prt)==false)
                .ToList();
        }
    }
}
