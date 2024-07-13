

using Microsoft.EntityFrameworkCore;
using RoomieFinderCore.Contracts.StudentContracts;
using RoomieFinderCore.Dtos.QuestionDtos;
using RoomieFinderInfrastructure.Models;
using RoomieFinderInfrastructure.UnitOfWork;

namespace RoomieFinderCore.Services.StudentServices
{
    public class StudentAnswerService : IStudentAnswerContract
    {

        private readonly IUnitOfWork _unitOfWork;
        public StudentAnswerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task UploadAnswersAsync(int studentId, List<int> selectedIds)
        {
            List<StudentAnswer> studentAnswers = new List<StudentAnswer>();
            selectedIds.ForEach(si =>
            {
                studentAnswers.Add(new StudentAnswer()
                {
                    AnswerId = si,
                    StudentId = studentId
                });
            });

            await _unitOfWork.AddManyAsync(studentAnswers);

            await _unitOfWork.SaveChangesAsync();
        }

        public async Task ResetStudentAnswersForAStudentAsync(int studentId)
        {
            var studentAnswers = await _unitOfWork.GetAllAsReadOnlyAsync<StudentAnswer>()
                 .Where(sa => sa.StudentId == studentId)
                  .ToListAsync();

            _unitOfWork.RemoveAll(studentAnswers);

            await _unitOfWork.SaveChangesAsync();
        }
    }
}
