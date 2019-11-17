using Bl0g.LogSink.Core.Models;
using Bl0g.LogSink.Interfaces;
using System;

namespace Bl0g.Content.ConsoleApp.Mappers
{
    public class ConsoleAppEventIdMapper : IEventIdMapper
    {
        public IEventClassification GetEventClassification(string className, string methodName, int area, Exception exception)
        {
            if (exception == null)
                return new UnClassifiedEventClassification();
            else
                return new UnclassifiedExceptionEventClassification();
        }
    }
}
