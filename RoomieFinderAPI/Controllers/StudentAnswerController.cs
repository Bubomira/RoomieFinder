using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RoomieFinderCore.Contracts.QuestionaireContracts;
using RoomieFinderCore.Contracts.StudentContracts;
using RoomieFinderCore.Dtos.QuestionaireDtos;
using System.Security.Claims;

namespace RoomieFinderAPI.Controllers
{
    [ApiController]
    [Route("student/answer")]
    [Authorize(Roles = "Student", AuthenticationSchemes = "Bearer")]
    public class StudentAnswerController : ControllerBase
    {
        private readonly IStudentContract _studentContract;
        private readonly IStudentAnswerContract _studentAnswerContract;
        private readonly IQuestionaireCheckerContract _questionaireCheckerContract;
        public StudentAnswerController(IStudentAnswerContract studentAnswerContract,
            IQuestionaireCheckerContract questionaireCheckerContract,
            IStudentContract studentContract)
        {
            _studentContract = studentContract;
            _studentAnswerContract = studentAnswerContract;
            _questionaireCheckerContract = questionaireCheckerContract;
        }

        [HttpPost("submit")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> SubmitAnswers([FromBody] FilledQuestionairePostDto filledQuestionairePostDto)
        {
            if (ModelState.IsValid && filledQuestionairePostDto.IsCompletelyFilled)
            {
                if (await _questionaireCheckerContract.CheckIfQuestionaireCanBeFilledOutAsync(filledQuestionairePostDto.QuestionaireId)
                   && !await _questionaireCheckerContract.CheckIfQuestionaireIsFilledOutByStudentAsync(filledQuestionairePostDto.QuestionaireId, User.Id() ?? "")
                   && await _questionaireCheckerContract.CheckIfAllAnswersBelongToTheQuestionaire(filledQuestionairePostDto.QuestionaireId, filledQuestionairePostDto.ChosenAnswersIds))
                {
                    var studentId = await _studentContract.GetStudentIdAsync(User.Id() ?? "");
                    await _studentAnswerContract.UploadAnswersAsync(studentId, filledQuestionairePostDto.ChosenAnswersIds);
                    return Created();
                }
            }
            return BadRequest();
        }

        [HttpGet("reset")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> ResetStudentAnswers([FromQuery] int questionaireId)
        {
            if (await _questionaireCheckerContract.CheckIfQuestionaireIsFilledOutByStudentAsync(questionaireId, User.Id() ?? ""))
            {
                int studentId = await _studentContract.GetStudentIdAsync(User.Id() ?? "");
                await _studentAnswerContract.ResetStudentAnswersForAStudentAsync(studentId, questionaireId);

                return NoContent();

            }
            return BadRequest();
        }
    }
}
