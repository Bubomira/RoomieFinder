﻿
using RoomieFinderCore.Dtos.StudentDtos;

namespace RoomieFinderCore.Contracts.RoomContracts
{
    public interface IRoomContract
    {
        /// <summary>
        /// Asigns room to a student 
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="roomId"></param>
        /// <returns></returns>
        public Task AsignRoomToStudentAsync(string userId, int roomId);

        /// <summary>
        /// Gets the id of a student's room
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="roomId"></param>
        /// <returns></returns>
        public Task<int?> GetStudentsRoomIdByUserIdAsync(string userId);

        /// <summary>
        /// Removes a student from a given room
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="roomId"></param>
        /// <returns></returns>
        public Task RemoveStudentFromARoomAsync(string userId);

        /// <summary>
        /// removes all of the recently graduated students from the rooms
        /// </summary>
        /// <returns></returns>
        public Task RemoveRecentlyGraduatedStudentsFromRoomsAsync();

        /// <summary>
        /// Gets all of the students who need to be assigned to a room
        /// </summary>
        /// <returns></returns>
        public Task GetAllStudentsWithoutARoomAsync(StudentListDto roomlessStudentsListDto);
    }

}
