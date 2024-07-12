using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RoomieFinderCore.Contracts.QuestionaireContracts;
using RoomieFinderCore.Contracts.QuestionContracts;
using RoomieFinderCore.Dtos.QuestionDtos;
using RoomieFinderInfrastructure.Models;

namespace RoomieFinderAPI.Controllers
{
    [ApiController]
    [Route("question")]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionContract _questionContract;
        private readonly IQuestionCheckerContract _questionCheckerContract;
        private readonly IQuestionaireCheckerContract _questionaireCheckerContract;
        public QuestionController(IQuestionContract questionContract,
         IQuestionCheckerContract questionCheckerContract,
         IQuestionaireCheckerContract questionaireCheckerContract)
        {
            _questionContract = questionContract;
            _questionCheckerContract = questionCheckerContract;
            _questionaireCheckerContract = questionaireCheckerContract;
        }

        [HttpPost("add/to/questionaire/{questionaireId}")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [Authorize(Roles = "GreatAdmin", AuthenticationSchemes = "Bearer")]
        public async Task<IActionResult> AddQuestionToQuestionaire([FromBody] QuestionPostDto questionPostDto, int questionaireId)
        {
            if (ModelState.IsValid)
            {
                if (await _questionaireCheckerContract.CheckIfQuestionaireExistsByIdAsync(questionaireId) &&
                    await _questionaireCheckerContract.CheckIfQuestionaireCanBeFilledOutAsync(questionaireId))
                {
                    await _questionContract.AddQuestionToQuestionaireAsync(questionaireId, questionPostDto);
                    return Created();
                }
                return NotFound();
            }

            return BadRequest();
        }


        [HttpPost("update/{questionId}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(403)]
        [ProducesResponseType(404)]
        [Authorize(Roles = "GreatAdmin", AuthenticationSchemes = "Bearer")]
        public async Task<IActionResult> UpdateQuestionMetadata([FromBody] QuestionUpdateMetadataDto questionUpdateMetadataDto, int questionId)
        {
            if (ModelState.IsValid)
            {
                if (await _questionCheckerContract.CheckIfQuestionExistsAsync(questionId) &&
                    await _questionCheckerContract.CheckIfQuestionIsAttachedToQuestionaireAsync(questionId, questionUpdateMetadataDto.QuestionaireId))
                {

                    if (await _questionaireCheckerContract.CheckIfQuestionaireCanBeFilledOutAsync(questionUpdateMetadataDto.QuestionaireId))
                    {
                        await _questionContract.UpdateQuestionMetadataAsync(questionId, questionUpdateMetadataDto);
                        return NoContent();
                    }
                    return Forbid();
                }
                return NotFound();
            }

            return BadRequest();
        }

        [HttpPost("delete/{questionId}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(403)]
        [ProducesResponseType(404)]
        [Authorize(Roles = "GreatAdmin", AuthenticationSchemes = "Bearer")]
        public async Task<IActionResult> DeleteQuestion(int questionId, [FromQuery] int questionaireId)
        {
            if (await _questionCheckerContract.CheckIfQuestionExistsAsync(questionId) &&
                await _questionCheckerContract.CheckIfQuestionIsAttachedToQuestionaireAsync(questionId, questionaireId))
            {

                if (await _questionaireCheckerContract.CheckIfQuestionaireCanBeFilledOutAsync(questionaireId))
                {
                    await _questionContract.DeleteQuestionFromQuestionaireAsync(questionId);
                    return NoContent();
                }
                return Forbid();
            }
            return NotFound();
        }
    }
}
