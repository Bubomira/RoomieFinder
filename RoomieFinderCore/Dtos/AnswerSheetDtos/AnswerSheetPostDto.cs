

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace RoomieFinderCore.Dtos.AnswerSheetDtos
{
    public class AnswerSheetPostDto : AnswerSheetMetadataDto
    {

        public IList<int> QualityIds { get; set; } =
            new List<int>();
    }
}
