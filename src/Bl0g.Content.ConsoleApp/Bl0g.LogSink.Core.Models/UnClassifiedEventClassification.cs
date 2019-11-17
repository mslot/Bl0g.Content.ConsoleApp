using Bl0g.LogSink.Interfaces;
using System;

namespace Bl0g.LogSink.Core.Models
{
    public class UnClassifiedEventClassification : IEventClassification
    {
        private string _name = "UnClassifiedEvent";
        public int EventId { get => 0; set => _ = 0; }
        public string Name { get => _name; set => _name=value; }
    }
}
