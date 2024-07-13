
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RoomieFinderCore.Contracts.QuestionaireContracts;
using RoomieFinderCore.Dtos.QuestionaireDtos;
using RoomieFinderInfrastructure.Models;
using System.Security.Claims;

namespace RoomieFinderAPI.Controllers
{
    [ApiController]
    [Route("questionaire")]
    public class QuestionaireController : ControllerBase
    {
        private readonly IQuestionaireContract _questionaireContract;
        private readonly IQuestionaireCheckerContract _questionaireCheckerContract;
        private readonly IQuestionaireGetContract _questionaireGetContract;
        public QuestionaireController(IQuestionaireContract questionaireContract,
            IQuestionaireCheckerContract questionaireCheckerContract,
            IQuestionaireGetContract questionaireGetContract)
        {
            _questionaireContract = questionaireContract;
            _questionaireCheckerContract = questionaireCheckerContract;
            _questionaireGetContract = questionaireGetContract;
        }

        [HttpPost("create")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [Authorize(Roles = "GreatAdmin", AuthenticationSchemes = "Bearer")]
        public async Task<IActionResult> AddQuestionaireWithQuestions([FromBody] QuestionairePostDto questionairePostDto)
        {
            if (ModelState.IsValid)
            {
                await _questionaireContract.AddQuestionaireWithQuestionsAsync(questionairePostDto);
                return Created();
            }

            return BadRequest();
        }

        [HttpPut("update/{questionaireId}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [Authorize(Roles = "GreatAdmin", AuthenticationSchemes = "Bearer")]

        public async Task<IActionResult> UpdateQuestionaire([FromBody] QuestionaireUpdateDto questionaireUpdateDto, int questionaireId)
        {
            if (ModelState.IsValid)
            {
                if (await _questionaireCheckerContract.CheckIfQuestionaireExistsByIdAsync(questionaireId))
                {
                    await _questionaireContract.UpdateQuestionaireAsync(questionaireUpdateDto);
                    return NoContent();
                }

                return NotFound();
            }

            return BadRequest();
        }

        [HttpDelete("delete/{questionaireId}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        [Authorize(Roles = "GreatAdmin", AuthenticationSchemes = "Bearer")]
        public async Task<IActionResult> DeleteQuestionaire(int questionaireId)
        {
            if (await _questionaireCheckerContract.CheckIfQuestionaireExistsByIdAsync(questionaireId))
            {
                await _questionaireContract.DeleteQuestionaireAsync(questionaireId);
                return NoContent();
            }
            return NotFound();
        }

        [HttpGet("details/{questionaireId}")]
        [ProducesResponseType(204, Type = typeof(QuestionaireDetailsDto))]
        [ProducesResponseType(404)]
        [ProducesResponseType(403)]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public async Task<IActionResult> GetEmptyQuestionaireDetails(int questionaireId, [FromQuery] string userId)
        {
            if (await _questionaireCheckerContract.CheckIfQuestionaireExistsByIdAsync(questionaireId))
            {
                if ((User.IsInRole("Student") &&
                    await _questionaireCheckerContract.CheckIfQuestionaireCanBeFilledOutAsync(questionaireId) &&
                    string.IsNullOrEmpty(userId)))
                {
                    var applicationUserId = User.Id();
                    return Ok(await _questionaireGetContract.GetQuestionaireByIdAsync(questionaireId,
                              await _questionaireCheckerContract.CheckIfQuestionaireIsFilledOutByStudentAsync(questionaireId, applicationUserId),
                              applicationUserId));
                }
                else if (User.IsInRole("GreatAdmin"))
                {
                    if (string.IsNullOrEmpty(userId))
                    {
                        return Ok(await _questionaireGetContract.GetQuestionaireByIdAsync(questionaireId, false, String.Empty));
                    }
                    else
                    {
                        return Ok(await _questionaireGetContract.GetQuestionaireByIdAsync(questionaireId,
                                 await _questionaireCheckerContract.CheckIfQuestionaireIsFilledOutByStudentAsync(questionaireId, userId),
                                 userId));
                    }
                }

                return Unauthorized();
            }
            return NotFound();
        }

        [HttpGet("make/fillable/{questionaireId}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        [Authorize(Roles = "GreatAdmin", AuthenticationSchemes = "Bearer")]
        public async Task<IActionResult> MakeQuestionaireFillable(int questionaireId)
        {
            if (await _questionaireCheckerContract.CheckIfQuestionaireExistsByIdAsync(questionaireId))
            {
                await _questionaireContract.MakeQuestionaireFillableAsync(questionaireId);
                return NoContent();
            }

            return NotFound();
        }

        [HttpGet("all")]
        [ProducesResponseType(400)]
        [ProducesResponseType(200, Type = typeof(List<QuestionairePreviewDto>))]
        [Authorize(AuthenticationSchemes = "Bearer")]

        public async Task<IActionResult> GetAllQuestionairs([FromQuery] QuestionaireQueryInformationDto questionaireQueryInformationDto)
        {
            if (questionaireQueryInformationDto.PageNumber < 1)
            {
                return BadRequest();
            }

            await _questionaireGetContract.GetQuestionairsAsync(questionaireQueryInformationDto, User.IsInRole("GreatAdmin"));

            if (questionaireQueryInformationDto.PageNumber * QuestionaireQueryInformationDto.ItemsPerPage >
                questionaireQueryInformationDto.TotalResults)
            {
                return BadRequest();
            }

            return Ok(questionaireQueryInformationDto.QuestionairePreviewDtos);
        }

    }
}
