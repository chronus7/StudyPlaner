using Studyplaner.Logging.Targets;
using System;
using System.Collections.Generic;
using System.Text;

namespace Studyplaner.Logging
{
    public static class LoggingManager
    {
        private const string ERROR_TARGET_NULL = "A valid ILogTarget has not been set yet!";

        private static List<ILogTarget> _logTargets;
        private static StringBuilder _builder;

        private static bool _writeTime = Properties.Settings.Default.USER_LOGGING_WRITETIME;

        /// <summary>
        /// Initializes logging.
        /// Does stuff like setting the targets etc.
        /// </summary>
        public static void Initialize()
        {
            if (Properties.Settings.Default.USER_LOGGING_TOCONSOLE)
                AddTarget(new FormLogTarget());
            else if (Properties.Settings.Default.USER_LOGGING_TOFILE)
                AddTarget(new FileLogTarget(Properties.Settings.Default.USER_LOGGING_PATH));

            SetWriteTime(Properties.Settings.Default.USER_LOGGING_WRITETIME);
            LogEvent(LogEventType.DEBUG, "Logging has been successfully initialized!");
        }

        /// <summary>
        /// Sets the value wether the current time shall be
        /// appended to the log or not.
        /// </summary>
        /// <param name="value">True to enable the time. False else.</param>
        public static void SetWriteTime(bool value)
        {
            _writeTime = value;
        }

        /// <summary>
        /// Returns wether a valid ILogTarget has been chosen and initialized
        /// </summary>
        /// <returns>The result</returns>
        public static bool HasValidTarget()
        {
            return (_logTargets != null && _logTargets.Count > 0);
        }

        /// <summary>
        /// Adds an ILogTarget to the LogService
        /// </summary>
        /// <param name="target">The ILogTarget to add</param>
        public static void AddTarget(ILogTarget target)
        {
            if (target == null)
                throw new ArgumentNullException("target");
            if (_logTargets == null)
                _logTargets = new List<ILogTarget>();

            if (!_logTargets.Contains(target))
                _logTargets.Add(target);
        }

        /// <summary>
        /// Selects a new ILogTarget to log to TODO: |f| might want to add a feature to carry over existing logs
        /// </summary>
        public static void SelectSingleTarget(ILogTarget target)
        {
            if (target == null)
                throw new ArgumentNullException("target");

            DisposeTargets();
            _logTargets = new List<ILogTarget>();       // no need to check for null since we want to replace the whole list

            _logTargets.Add(target);
        }

        /// <summary>
        /// Logs an event to the ILogTarget
        /// </summary>
        /// <param name="eventType">LogEventType of the event</param>
        /// <param name="message">corresponding message</param>
        public static void LogEvent(LogEventType eventType, string message)
        {
            if (Properties.Settings.Default.USER_LOGGING_ENABLED)
            {
                if (!HasValidTarget())
                    throw new LoggingException(ERROR_TARGET_NULL);

                if (_builder == null)
                    _builder = new StringBuilder();
                else
                    _builder.Clear();

                _builder.Append('[' + eventType.ToString() + ']');

                if (_writeTime)
                    _builder.Append('[' + DateTime.Now.ToLongTimeString() + ']');
                else
                    _builder.Append('\t');

                _builder.Append("\t" + message);

                WriteToTargets(_builder.ToString());
            }
        }

        private static void WriteToTargets(string logEntry)
        {
            foreach (ILogTarget target in _logTargets)
                target.WriteToLog(logEntry);
        }

        private static void DisposeTargets()
        {
            if(_logTargets != null)
                foreach (ILogTarget target in _logTargets)
                    target.Dispose();
        }
    }
}