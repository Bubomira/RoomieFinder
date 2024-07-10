using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RoomieFinderCore.Contracts.QuestionaireContracts;
using RoomieFinderCore.Dtos.AnswerDtos;

namespace RoomieFinderAPI.Controllers
{

    [ApiController]
    [Route("answer")]
    [Authorize(Roles = "GreatAdmin", AuthenticationSchemes = "Bearer")]
    public class AnswerController : ControllerBase
    {
        private readonly IAnswerContract _answerContract;
        private readonly IQuestionContract _questionContract;
        public AnswerController(IAnswerContract answerContract,
           IQuestionContract questionContract)
        {
            _answerContract = answerContract;
            _questionContract = questionContract;
        }

        [HttpPost("attach")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> AttachAnswerToQuestion([FromBody] AnswerAttachDto answerAttachDto)
        {
            if (ModelState.IsValid &&
                !await _answerContract.CheckIfThereIsAnotherAnswerWithTheSameContentAsync(answerAttachDto.QuestionId, answerAttachDto.Content) &&
                await _questionContract.CheckIfQuestionaireIsAttachedToEditableQuestionaireAsync(answerAttachDto.QuestionId))
            {
                await _answerContract.AtachAnswerToQuestionAsync(answerAttachDto);
                return Created();
            }
            return BadRequest();
        }

        [HttpPut("update/{answerId}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> UpdateAnswerContent([FromBody] AnswerUpdateDto answerUpdateDto, int answerId)
        {
            if (ModelState.IsValid || answerUpdateDto.Id != answerId)
            {
                if (await _answerContract.CheckIfAnswerExistsByIdAsync(answerId) &&
                    await _answerContract.CheckIfAnswerIsAttachedToEditableQuestionAsync(answerId))
                {
                    if (!await _answerContract.CheckIfThereIsAnotherAnswerWithTheSameContentAsync(answerUpdateDto.QuestionId, answerUpdateDto.Content))
                    {
                        await _answerContract.UpdateAnswerAsync(answerId, answerUpdateDto.Content);
                        return NoContent();
                    }
                    return BadRequest();
                }
                return NotFound();
            }
            return BadRequest();
        }
    }
}
