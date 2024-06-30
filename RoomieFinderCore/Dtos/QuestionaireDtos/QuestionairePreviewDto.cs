

namespace RoomieFinderCore.Dtos.QuestionaireDtos
{
    public class QuestionairePreviewDto
    {
        public int Id { get; set; }

        public required string Title { get; set; }

        public required string Description { get; set; }

        public bool CanQuestionaireBeEdited { get; set; }

    }
}
