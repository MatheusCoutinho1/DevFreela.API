using System.Reflection.Metadata.Ecma335;

namespace DevFreela.API.Models
{
    public class OpeningTimeOption
    {
        public TimeSpan StartAt { get; set; }
        public TimeSpan FinishAt { get; set; }
    }
}
