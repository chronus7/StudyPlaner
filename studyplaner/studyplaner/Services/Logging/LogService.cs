using Studyplaner.Interfaces;
using Studyplaner.Various.InheritedExceptions;

namespace Studyplaner.Services.Logging
{
    public static class LogService
    {
        private const string ERROR_TARGET_NULL = "The ILogTarget has not been set yet!";

        private static ILogTarget _logTarget;

        /// <summary>
        /// Wird nicht so bleiben ;)
        /// </summary>
        public static void SwitchTarget(ILogTarget target)
        {
            _logTarget = target;
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
            else
                throw new LoggingException(ERROR_TARGET_NULL);
        }

        public static ILogTarget GetLogTarget()
        {
            if (_logTarget != null)
                return _logTarget;

            throw new LoggingException(ERROR_TARGET_NULL);
        }
    }
}