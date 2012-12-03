using Studyplaner.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Studyplaner.Services.Logging
{
    public static class LogService
    {
        private static ILogTarget _logTarget;

        /// <summary>
        /// Wird nicht so bleiben ;)
        /// </summary>
        public static void SwitchToConsole()
        {
            LogFormTarget target = _logTarget as LogFormTarget;
            if(target == null)
                _logTarget = new LogFormTarget();
        }

        public static void LogToOutput(Enums.LogEventType eventType, string message)
        {
            if(_logTarget != null)
                _logTarget.WriteToLog(eventType, message);
        }
    }
}
