﻿
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RoomieFinderCore.Contracts.QuestionaireContracts;
using RoomieFinderCore.Dtos.QuestionaireDtos;
using RoomieFinderCore.Dtos.QuestionDtos;

namespace RoomieFinderAPI.Controllers
{
    [ApiController]
    [Route("questionaire")]
    public class QuestionaireController : ControllerBase
    {
        private readonly IQuestionaireContract _questionaireContract;
        public QuestionaireController(IQuestionaireContract questionaireContract)
        {
            _questionaireContract = questionaireContract;
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

        [HttpPut("update/:questionaireId")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [Authorize(Roles = "GreatAdmin", AuthenticationSchemes = "Bearer")]

        public async Task<IActionResult> UpdateQuestionaire([FromBody] QuestionaireUpdateDto questionaireUpdateDto, int questionaireId)
        {
            if (ModelState.IsValid)
            {
                if (await _questionaireContract.CheckIfQuestionaireExistsByIdAsync(questionaireId))
                {
                    await _questionaireContract.UpdateQuestionaireAsync(questionaireUpdateDto);
                    return NoContent();
                }

                return NotFound();
            }

            return BadRequest();
        }

        [HttpDelete("delete/:questionaireId")]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        [Authorize(Roles = "GreatAdmin", AuthenticationSchemes = "Bearer")]
        public async Task<IActionResult> DeleteQuestionaire(int questionaireId)
        {
            if (await _questionaireContract.CheckIfQuestionaireExistsByIdAsync(questionaireId))
            {
                await _questionaireContract.DeleteQuestionaireAsync(questionaireId);
                return NoContent();
            }
            return NotFound();
        }

        [HttpGet("details/:questionaireId")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public async Task<IActionResult> GetEmptyQuestionaireDetails(int questionaireId)
        {
            if (await _questionaireContract.CheckIfQuestionaireExistsByIdAsync(questionaireId))
            {
                return Ok(await _questionaireContract.GetQuestionaireByIdAsync(questionaireId));
            }

            return NotFound();
        }
    }
}
