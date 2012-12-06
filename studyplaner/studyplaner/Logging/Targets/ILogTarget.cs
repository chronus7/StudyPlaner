using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Studyplaner.Logging.Targets
{
    public interface ILogTarget
    {
        /// <summary>
        /// Sets a value indicating wether the time of an event shall be written to the ILogTarget
        /// </summary>
        /// <param name="value">Value indicating wether the time of an event shall be written to the ILogTarget</param>
        void SetTimeVisible(bool value);

        /// <summary>
        /// Writes a Message and a given LogEventType to the ILogTarget
        /// </summary>
        /// <param name="eventType">The LogEventType of the event</param>
        /// <param name="message">The corresponding message to the event</param>
        void WriteToLog(UniversityStuff.LogEventType eventType, string message);
    }
}
