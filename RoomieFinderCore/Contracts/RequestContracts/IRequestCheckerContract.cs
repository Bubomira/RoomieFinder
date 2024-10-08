﻿

using RoomieFinderInfrastructure.Enums;

namespace RoomieFinderCore.Contracts.RequestContracts
{
    public interface IRequestCheckerContract
    {
        /// <summary>
        /// Checks if a request exists by id
        /// </summary>
        /// <param name="requestId"></param>
        /// <returns></returns>
        public Task<bool> CheckIfRequestExistsByIdAsync(int requestId);

        /// <summary>
        /// Checks if a student is male by request id to fulfill gender regulations
        /// </summary>
        /// <param name="requestId"></param>
        /// <returns></returns>
        public Task<bool> CheckIfStudentIsMaleByRequestIdAsync(int requestId);

        /// <summary>
        /// Checks if the given request is of the wanted type
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="requestType"></param>
        /// <returns></returns>
        public Task<bool> CheckIfRequestIsOfTypeAsync(int requestId, RequestType requestType);

        /// <summary>
        /// Checks if the wanted request is submitted by the user
        /// </summary>
        /// <param name="requestId"></param>
        /// <returns></returns>
        public Task<bool> ChecksIfRequestIsSubmittedByUserAsync(int requestId, string userId);


        /// <summary>
        /// Checks if the wanted request is submitted by the user and is pending
        /// </summary>
        /// <param name="requestId"></param>
        /// <returns></returns>
        public Task<bool> ChecksIfTheRequestIsSubmittedByUserAndPendingAsync(int requestId, string userId);

        /// <summary>
        /// Checks if there is another request of the same type by a student
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="requestType"></param>
        /// <returns></returns>
        public Task<bool> CheckIfThereIsAnotherUnArchivedRequestOfTypeForUserAsync(string userId,RequestType requestType);
    }
}
