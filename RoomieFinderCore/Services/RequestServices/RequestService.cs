using Microsoft.EntityFrameworkCore;
using RoomieFinderCore.Contracts.RequestContracts;
using RoomieFinderCore.Dtos.RequestDtos;
using RoomieFinderInfrastructure.Enums;
using RoomieFinderInfrastructure.Models;
using RoomieFinderInfrastructure.UnitOfWork;

using static RoomieFinderInfrastructure.Constants.ModelConstants.RoomConstants;

namespace RoomieFinderCore.Services.RequestServices
{
    public class RequestService : IRequestContract
    {
        private readonly IUnitOfWork _unitOfWork;

        public RequestService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<string?> GetSpecificRoomateEmailByRequestId(int requestId) =>
            _unitOfWork.GetAllAsReadOnlyAsync<Request>()
            .Where(r => r.Id == requestId)
            .Select(r => r.Comment)
            .FirstOrDefaultAsync();
        public async Task GetAllRequestsAsync(RequestListDto requestListDto)
        {
            var requests = _unitOfWork.GetAllAsReadOnlyAsync<Request>();

            if (requestListDto.PrefferedRequestType != RequestType.DoesntMatter)
            {
                requests = requests.Where(r => r.RequestType == requestListDto.PrefferedRequestType);
            }

            if (requestListDto.PrefferedRequestStatus != RequestStatus.DoesntMatter)
            {
                requests = requests.Where(r => r.RequestStatus == requestListDto.PrefferedRequestStatus);
            }

            requestListDto.TotalCount = await requests.CountAsync();

            requestListDto.Requests = await requests
                .Skip((requestListDto.CurrentPage - 1) * RequestListDto.MaxItemsOnPage)
                .Take(RequestListDto.MaxItemsOnPage)
                .Select(r => new RequestSearchPreviewDto()
                {
                    Id = r.Id,
                    RequesterEmail=r.Student.ApplicationUser.Email,
                    RequestStatus = r.RequestStatus,
                    RequestType = r.RequestType
                })
                .ToListAsync();
        }

        public async Task<RequestDetailsDto> GetRequestDetailsAsync(int requestId,bool isMale)
        {
            var requestDetails = await _unitOfWork.GetAllAsReadOnlyAsync<Request>()
            .Where(r => r.Id == requestId)
            .Select(r => new RequestDetailsDto()
            {
                Id = r.Id,
                Comment = r.Comment,
                RequestType = r.RequestType,
                RequestStatus = r.RequestStatus,
                RequesterEmail=r.Student.ApplicationUser.Email,
                RequesterUserId = r.Student.ApplicationUserId,
                RequesterFullName = $"{r.Student.ApplicationUser.FirstName} {r.Student.ApplicationUser.LastName}"
            })
            .FirstAsync();

            if (requestDetails.RequestStatus == RequestStatus.Pending)
            {
                switch (requestDetails.RequestType)
                {
                    case RequestType.SingleRoom:
                        requestDetails.CanBeAccepted = (await _unitOfWork.GetAllAsReadOnlyAsync<Room>()
                            .AnyAsync(r => r.RoomType == RoomType.Single && r.RemainingCapacity > NoCapacityLeft)
                            &&
                            (await _unitOfWork.GetAllAsReadOnlyAsync<Student>()
                            .AnyAsync(s => s.ApplicationUserId == requestDetails.RequesterUserId && s.Room == null)));

                        break;
                    case RequestType.ChangeRoom:
                        requestDetails.CanBeAccepted = (await _unitOfWork.GetAllAsReadOnlyAsync<Student>()
                             .AnyAsync(s => s.ApplicationUserId == requestDetails.RequesterUserId && s.Room != null))
                             &&
                             (await _unitOfWork.GetAllAsReadOnlyAsync<Room>()
                            .AnyAsync(r => r.RemainingCapacity > NoCapacityLeft && (r.Students.Count==0 || r.Students.Any(s=>s.IsMale==isMale))));

                        break;
                    case RequestType.SpecificRoomate:
                        requestDetails.CanBeAccepted = (await _unitOfWork.GetAllAsReadOnlyAsync<Student>()
                            .AnyAsync(s => s.ApplicationUserId == requestDetails.RequesterUserId && s.Room == null))
                            &&
                            (await _unitOfWork.GetAllAsReadOnlyAsync<Student>()
                            .AnyAsync(s => s.ApplicationUser.Email == requestDetails.Comment && s.Room == null))
                            &&
                            (await _unitOfWork.GetAllAsReadOnlyAsync<Room>()
                            .AnyAsync(r => r.RemainingCapacity >= DoubleCapcity && (r.Students.Count == 0 || r.Students.Any(s => s.IsMale == isMale))));

                        break;
                }
            }

            return requestDetails;
        }

        public async Task SubmitRequestAsync(RequestPostDto requestPostDto, int studentId)
        {
            Request request = new Request()
            {
                StudentId = studentId,
                Comment = requestPostDto.Comment,
                RequestStatus = RequestStatus.Pending,
                RequestType = requestPostDto.RequestType
            };

            await _unitOfWork.AddEntityAsync(request);

            await _unitOfWork.SaveChangesAsync();
        }

        public Task RemoveRequestAsync(int requestId) =>
            _unitOfWork.GetAllAsync<Request>()
            .Where(r => r.Id == requestId)
            .ExecuteDeleteAsync();

    }
}
