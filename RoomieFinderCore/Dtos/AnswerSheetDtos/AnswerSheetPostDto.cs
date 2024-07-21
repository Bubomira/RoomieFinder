
namespace RoomieFinderCore.Dtos.AnswerSheetDtos
{
    public class AnswerSheetPostDto : AnswerSheetMetadataDto
    {
        public List<int> QualityIds { get; set; } =
            new List<int>();
    }
}
