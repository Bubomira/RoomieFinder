

using RoomieFinderInfrastructure.Enums;

namespace RoomieFinderCore.Dtos.QuestionaireDtos
{
    public class QuestionaireQueryInformationDto
    {
        public static int ItemsPerPage = 10;


        public int PageNumber { get; set; }
        public int TotalResults { get; set; }


        public string? SearchString { get; set; } 
        public CanQuestionaireBeEdited CanQuestionaireBeEdited { get; set; }

        public List<QuestionairePreviewDto> QuestionairePreviewDtos { get; set; }
            = new List<QuestionairePreviewDto>();
    }
}
