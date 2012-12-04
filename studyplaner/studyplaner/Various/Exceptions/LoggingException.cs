using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Studyplaner.Various.Exceptions
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
        // TODO: nothing to do here ;)
    }
}
