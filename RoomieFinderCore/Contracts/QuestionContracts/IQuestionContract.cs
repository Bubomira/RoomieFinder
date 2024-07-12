﻿using RoomieFinderCore.Dtos.QuestionDtos;


namespace RoomieFinderCore.Contracts.QuestionContracts
{
    public interface IQuestionContract
    {
        /// <summary>
        /// Adds a newly created question with its answers to an already existing questionaire
        /// </summary>
        /// <param name="questionaireId"></param>
        /// <param name="questionPostDto"></param>
        /// <returns></returns>
        public Task AddQuestionToQuestionaireAsync(int questionaireId, QuestionPostDto questionPostDto);
        /// <summary>
        /// Updates questions content and type
        /// </summary>
        /// <param name="questionId"></param>
        /// <param name="questionPostDto"></param>
        /// <returns></returns>
        public Task UpdateQuestionMetadataAsync(int questionId, QuestionUpdateMetadataDto questionPostDto);

        /// <summary>
        /// Removes an existing question alongside with its answers from a questionaire
        /// </summary>
        /// <param name="questionId"></param>
        /// <returns></returns>
        public Task DeleteQuestionFromQuestionaireAsync(int questionId);

      
    }
}