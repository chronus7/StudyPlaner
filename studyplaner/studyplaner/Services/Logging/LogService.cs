using Studyplaner.Interfaces;
using Studyplaner.Various.Exceptions;

namespace Studyplaner.Services.Logging
{
    public static class LoggingService
    {
        private const string ERROR_TARGET_NULL = "The ILogTarget has not been set yet!";

        private static ILogTarget _logTarget;

        /// <summary>
        /// Returns wether a valid ILogTarget has been chosen and initialized
        /// </summary>
        /// <returns>the value</returns>
        public static bool HasValidTarget()
        {
            return _logTarget != null;
        }

        /// <summary>
        /// Selects a new ILogTarget to log to TODO: |f| might want to add a feature to carry over existing logs
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
            if (Properties.Settings.Default.USER_LOG_ENABLED)
            {
                if (HasValidTarget())
                    _logTarget.WriteToLog(eventType, message);
                else
                    throw new LoggingException(ERROR_TARGET_NULL);
            }
        }
    }
}