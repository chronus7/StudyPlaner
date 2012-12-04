using Studyplaner.Interfaces;
using Studyplaner.Various.Exceptions;
using System;
using System.Collections.Generic;

namespace Studyplaner.Services.Logging
{
    public static class LoggingService
    {
        private const string ERROR_TARGET_NULL = "A valid ILogTarget has not been set yet!";

        private static List<ILogTarget> _logTargets;

        /// <summary>
        /// Returns wether a valid ILogTarget has been chosen and initialized
        /// </summary>
        /// <returns>the value</returns>
        public static bool HasValidTarget()
        {
            return (_logTargets != null && _logTargets.Count > 0);
        }

        public static void AddTarget(ILogTarget target)
        {
            if (target == null)
                throw new ArgumentNullException("target");
            if (_logTargets == null)
                throw new LoggingException(ERROR_TARGET_NULL);

            if (!_logTargets.Contains(target))
                _logTargets.Add(target);
        }

        /// <summary>
        /// Selects a new ILogTarget to log to TODO: |f| might want to add a feature to carry over existing logs
        /// </summary>
        public static void SwitchTarget(ILogTarget target)
        {
            if (_logTargets == null)
                _logTargets = new List<ILogTarget>();

            
        }

        /// <summary>
        /// Logs an event to the ILogTarget
        /// </summary>
        /// <param name="eventType">LogEventType of the event</param>
        /// <param name="message">corresponding message</param>
        public static void LogEvent(Enums.LogEventType eventType, string message)
        {
            if (Properties.Settings.Default.USER_LOG_ENABLED)
            {
                if (HasValidTarget())
                    WriteToTargets(eventType, message);
                else
                    throw new LoggingException(ERROR_TARGET_NULL);
            }
        }

        private static void WriteToTargets(Enums.LogEventType eventType, string message)
        {
            foreach (ILogTarget target in _logTargets)
                target.WriteToLog(eventType, message);
        }
    }
}