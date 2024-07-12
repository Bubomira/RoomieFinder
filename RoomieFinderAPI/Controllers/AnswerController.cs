using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RoomieFinderCore.Contracts.AnswerContracts;
using RoomieFinderCore.Contracts.QuestionContracts;
using RoomieFinderCore.Dtos.AnswerDtos;

namespace RoomieFinderAPI.Controllers
{

    [ApiController]
    [Route("answer")]
    [Authorize(Roles = "GreatAdmin", AuthenticationSchemes = "Bearer")]
    public class AnswerController : ControllerBase
    {
        private readonly IAnswerContract _answerContract;
        private readonly IAnswerCheckerContract _answerCheckerContract;
        private readonly IQuestionCheckerContract _questionCheckerContract;
        public AnswerController(IAnswerContract answerContract,
           IAnswerCheckerContract answerCheckerContract,
           IQuestionCheckerContract questionCheckerContract)
        {
            _answerContract = answerContract;
            _answerCheckerContract = answerCheckerContract;
            _questionCheckerContract = questionCheckerContract;
        }

        [HttpPost("attach")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> AttachAnswerToQuestion([FromBody] AnswerAttachDto answerAttachDto)
        {
            if (ModelState.IsValid &&
                !await _answerCheckerContract.CheckIfThereIsAnotherAnswerWithTheSameContentAsync(answerAttachDto.QuestionId, answerAttachDto.Content) &&
                await _questionCheckerContract.CheckIfQuestionaireIsAttachedToEditableQuestionaireAsync(answerAttachDto.QuestionId))
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
                if (await _answerCheckerContract.CheckIfAnswerExistsByIdAsync(answerId) &&
                    await _answerCheckerContract.CheckIfAnswerIsAttachedToEditableQuestionAsync(answerId))
                {
                    if (!await _answerCheckerContract.CheckIfThereIsAnotherAnswerWithTheSameContentAsync(answerUpdateDto.QuestionId, answerUpdateDto.Content))
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

        [HttpDelete("delete/{answerId}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> DeleteAnswer(int answerId)
        {
            if (await _answerCheckerContract.CheckIfAnswerExistsByIdAsync(answerId))
            {
                if (await _answerCheckerContract.CheckIfAnswerCouldBeDeletedFromQuestionAsync(answerId))
                {
                    await _answerContract.DeleteAnswerFromQuestionAsync(answerId);
                    return NoContent();
                }
                return BadRequest();
            }
            return NotFound();
        }
    }
}
