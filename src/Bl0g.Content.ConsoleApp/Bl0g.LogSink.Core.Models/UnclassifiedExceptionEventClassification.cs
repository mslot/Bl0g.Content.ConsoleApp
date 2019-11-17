using Bl0g.LogSink.Interfaces;

namespace Bl0g.LogSink.Core.Models
{
    public class UnclassifiedExceptionEventClassification : IEventClassification
    {
        private string _name = "UnClassifiedExceptionEvent";
        public int EventId { get => 6000; set => _ = 6000; }
        public string Name { get => _name; set => _name = value; }
    }
}
