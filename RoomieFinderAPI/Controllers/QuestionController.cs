using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RoomieFinderCore.Contracts.QuestionaireContracts;
using RoomieFinderCore.Dtos.QuestionDtos;
using RoomieFinderInfrastructure.Models;

namespace RoomieFinderAPI.Controllers
{
    [ApiController]
    [Route("question")]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionContract _questionContract;
        private readonly IQuestionaireContract _questionaireContract;
        public QuestionController(IQuestionContract questionContract,
         IQuestionaireContract questionaireContract)
        {
            _questionContract = questionContract;
            _questionaireContract = questionaireContract;
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
                if (await _questionaireContract.CheckIfQuestionaireExistsByIdAsync(questionaireId) &&
                    await _questionaireContract.CheckIfQuestionaireCanBeFilledOut(questionaireId))
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
                if (await _questionContract.CheckIfQuestionExistsAsync(questionId) &&
                    await _questionContract.CheckIfQuestionIsAttachedToQuestionaireAsync(questionId, questionUpdateMetadataDto.QuestionaireId))
                {

                    if (await _questionaireContract.CheckIfQuestionaireCanBeFilledOut(questionUpdateMetadataDto.QuestionaireId))
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
            if (ModelState.IsValid)
            {
                if (await _questionContract.CheckIfQuestionExistsAsync(questionId) &&
                    await _questionContract.CheckIfQuestionIsAttachedToQuestionaireAsync(questionId, questionaireId))
                {

                    if (await _questionaireContract.CheckIfQuestionaireCanBeFilledOut(questionaireId))
                    {
                        await _questionContract.DeleteQuestionFromQuestionaireAsync(questionId);
                        return NoContent();
                    }
                    return Forbid();
                }
                return NotFound();
            }

            return BadRequest();
        }
    }
}
