﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Studyplaner.Various.Exceptions
{
    public class LoggingException : Exception
    {
        public LoggingException(string message) : base(message) { 
        }
        // TODO: nothing to do here ;)
    }
}
