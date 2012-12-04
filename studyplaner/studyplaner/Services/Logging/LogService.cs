using Studyplaner.GUI.Forms;
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
        public static void SwitchToConsole(LogForm form)
        {
            LogFormTarget target = _logTarget as LogFormTarget;
            if(target == null)
                _logTarget = new LogFormTarget(form);
        }

        public static void SwitchToFile(string fileName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Logs an event to the ILogTarget
        /// </summary>
        /// <param name="eventType">LogEventType of the event</param>
        /// <param name="message">corresponding message</param>
        public static void LogToOutput(Enums.LogEventType eventType, string message)
        {
            if(_logTarget != null)
                _logTarget.WriteToLog(eventType, message);
        }

        public static ILogTarget GetLogTarget()
        {
            return _logTarget;
        }
    }
}
