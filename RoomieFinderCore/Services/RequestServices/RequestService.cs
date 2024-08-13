using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RoomieFinderCore.Contracts.RequestContracts;
using RoomieFinderCore.Dtos.RequestDtos;
using RoomieFinderInfrastructure.Enums;
using RoomieFinderInfrastructure.Models;
using RoomieFinderInfrastructure.UnitOfWork;

namespace RoomieFinderCore.Services.RequestServices
{
    public class RequestService : IRequestContract
    {
        private readonly IUnitOfWork _unitOfWork;

        public RequestService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
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

        public Task<RequestDetailsDto> GetRequestDetailsAsync(int requestId) =>
            _unitOfWork.GetAllAsReadOnlyAsync<Request>()
            .Where(r => r.Id == requestId)
            .Select(r => new RequestDetailsDto()
            {
                Id = r.Id,
                Comment = r.Comment,
                RequestType = r.RequestType,
                RequestStatus = r.RequestStatus,
                RequesterUserId = r.Student.ApplicationUserId,
                RequesterFullName = $"{r.Student.ApplicationUser.FirstName} {r.Student.ApplicationUser.LastName}"
            })
            .FirstAsync();

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
