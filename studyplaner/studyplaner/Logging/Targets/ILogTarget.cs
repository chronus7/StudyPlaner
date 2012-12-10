using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Studyplaner.Logging.Targets
{
    public interface ILogTarget : IDisposable
    {
        /// <summary>
        /// Writes a LogEntry to the ILogTarget
        /// </summary>
        /// <param name="message">The LogEntry to write</param>
        void WriteToLog(string logEntry);
    }
}
