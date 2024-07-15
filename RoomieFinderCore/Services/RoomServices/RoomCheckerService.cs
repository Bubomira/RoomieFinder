﻿

using Microsoft.EntityFrameworkCore;
using RoomieFinderCore.Contracts.RoomContracts;
using RoomieFinderInfrastructure.Models;
using RoomieFinderInfrastructure.UnitOfWork;

using static RoomieFinderInfrastructure.Constants.ModelConstants.RoomConstants;

namespace RoomieFinderCore.Services.RoomServices
{
    public class RoomCheckerService : IRoomCheckerContract
    {
        private readonly IUnitOfWork _unitOfWork;

        public RoomCheckerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Task<bool> CheckIfRoomExistsByIdAsync(int roomId) =>
            _unitOfWork.GetAllAsReadOnlyAsync<Room>()
            .AnyAsync(r => r.Id == roomId);


        public Task<bool> CheckIfRoomHasCapacityAsync(int roomId) =>
            _unitOfWork.GetAllAsReadOnlyAsync<Room>()
            .AnyAsync(r => r.Id == roomId && r.RemainingCapacity < NoCapacityLeft);


        public Task<bool> CheckIfStudentIsAlreadyAsignedToTheSpecifiedRoomAsync(string userId, int roomId) =>
            _unitOfWork.GetAllAsReadOnlyAsync<Student>()
            .AnyAsync(s => s.ApplicationUserId == userId && s.RoomId == roomId);

    }
}