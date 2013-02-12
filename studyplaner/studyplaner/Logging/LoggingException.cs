using System;

namespace Studyplaner.Logging
{
    public class LoggingException : Exception
    {
        public LoggingException(string message) 
            : base(message) 
        { 
        }

        public LoggingException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}