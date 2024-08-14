using RoomieFinderCore.Dtos.RequestDtos;

namespace RoomieFinderCore.Contracts.RequestContracts
{
    public interface IRequestContract
    {
        /// <summary>
        /// Adds a new request made by a student
        /// </summary>
        /// <param name="requestPostDto"></param>
        /// <param name="studentId"></param>
        /// <returns></returns>
        public Task SubmitRequestAsync(RequestPostDto requestPostDto, int studentId);

        /// <summary>
        /// Removes a request based of its id
        /// </summary>
        /// <param name="requestId"></param>
        /// <returns></returns>
        public Task RemoveRequestAsync(int requestId);

        /// <summary>
        /// Gets preview details about requests on the given page as well as their total count
        /// </summary>
        /// <param name="requestListDto"></param>
        /// <returns></returns>
        public Task GetAllRequestsAsync(RequestListDto requestListDto);

        /// <summary>
        /// Gets details about a request based of its id
        /// </summary>
        /// <param name="requestId"></param>
        /// <returns></returns>
        public Task<RequestDetailsDto> GetRequestDetailsAsync(int requestId,bool isMale);

        /// <summary>
        /// Gets the email of the wanted roomate if a student has requested a specific roomate
        /// </summary>
        /// <param name="requestId"></param>
        /// <returns></returns>
        public Task<string?> GetSpecificRoomateEmailByRequestId(int requestId);

    }
}
