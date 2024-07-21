using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RoomieFinderCore.Contracts.AnswerSheetContracts;
using RoomieFinderCore.Contracts.QualityContracts;
using RoomieFinderCore.Contracts.StudentContracts;
using RoomieFinderCore.Dtos.AnswerSheetDtos;
using RoomieFinderCore.Dtos.QualityDtos;
using System.Security.Claims;

namespace RoomieFinderAPI.Controllers
{
    [ApiController]
    [Route("answerSheet")]
    [Authorize(Roles = "Student", AuthenticationSchemes = "Bearer")]
    public class AnswerSheetController : ControllerBase
    {
        private IQualityContract _qualityContract;
        private IAnswerSheetContract _answerSheetContract;
        private IStudentContract _studentContract;

        public AnswerSheetController(IQualityContract qualityContract,
            IAnswerSheetContract answerSheetContract,
            IStudentContract studentContract
            )
        {
            _answerSheetContract = answerSheetContract;
            _qualityContract = qualityContract;
            _studentContract = studentContract;
        }

        [HttpGet("all/qualities")]
        [ProducesResponseType(200, Type = typeof(List<QualityPreviewDto>))]
        public async Task<IActionResult> GetAllQualities() =>
            Ok(await _qualityContract.GetAllQualitiesAsync());


        [HttpPost("submit")]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        public async Task<IActionResult> SubmitAnswers([FromBody] AnswerSheetPostDto answerSheetPostDto)
        {
            if (ModelState.IsValid && await _qualityContract.CheckIfAllQaulitiyIdsAreValidAsync(answerSheetPostDto.QualityIds))
            {
                var studentId = await _studentContract.GetStudentIdAsync(User.Id() ?? "");

                await _answerSheetContract.SaveAnswerSheetAnswersAsync(answerSheetPostDto, studentId);
                await _qualityContract.SaveQualitiesAsync(answerSheetPostDto.QualityIds, studentId);

                return NoContent();
            }
            return BadRequest();
        }

    }
}
