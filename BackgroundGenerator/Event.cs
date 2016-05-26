using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackgroundGenerator
{
    internal class Event
    {
        public IDictionary<string, string> EventType;

        public Guid EventId = Guid.Empty;

        public string EventText;

        public long DateInQuarterDays;

        public Event GenerateEvent(int minimumDateIncrement, int dateRandomness, int dramaModifier, int violenceModifier, int windfallModifier)
        {
            Event currentEvent = new Event();
            currentEvent.EventId = Guid.NewGuid();
            DateInQuarterDays = CalculateEventDate(minimumDateIncrement, dateRandomness);
            currentEvent.EventText = GetEventText(dramaModifier, violenceModifier, windfallModifier);
            //This means that this method has not been completed.
            throw new NotImplementedException();
        }

        private string GetEventText(int dramaModifier, int violenceModifier, int windfallModifier)
        {
            //This means that this method has not been completed.
            throw new NotImplementedException();
        }

        private long CalculateEventDate(int minimumDateIncrement, int dateRandomness)
        {
            Random generator = new Random(DateTime.Now.Millisecond);
            int dateAmalgam = (minimumDateIncrement + dateRandomness) * 4;
            long currentDate = generator.Next(minimumDateIncrement, dateAmalgam);
            return currentDate / 4;
        }
    }
}