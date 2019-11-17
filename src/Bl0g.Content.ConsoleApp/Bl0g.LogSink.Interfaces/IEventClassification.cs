using System;
using System.Collections.Generic;
using System.Text;

namespace Bl0g.LogSink.Interfaces
{
    public interface IEventClassification
    {
        int EventId { get; set; }
        string Name { get; set; }
    }
}
