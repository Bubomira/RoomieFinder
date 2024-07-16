

using RoomieFinderInfrastructure.Enums;

namespace RoomieFinderCore.Contracts.RequestContracts
{
    public interface IRequestStatusContract
    {
        /// <summary>
        /// Gets all of the request types a student can make in the current year
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public Task<List<RequestType>> GetPossibleRequestTypesAsync(string userId);


        /// <summary>
        /// Changes a request status by its id
        /// </summary>
        /// <param name="requestId"></param>
        /// <returns></returns>
        public Task ChangeRequestStatusAsync(int requestId, RequestStatus requestStatus);

        /// <summary>
        /// Archive all requests at the end of the school year
        /// </summary>
        /// <returns></returns>
        public Task ArchiveAllRequestsAsync();
    }
}
