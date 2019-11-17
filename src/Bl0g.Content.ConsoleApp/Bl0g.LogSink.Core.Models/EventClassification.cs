using Bl0g.LogSink.Interfaces;
using System;

namespace Bl0g.LogSink.Core.Models
{
    public class EventClassification : IEventClassification
    {
        public int EventId { get; set; }
        public string Name { get; set; }
    }
}
