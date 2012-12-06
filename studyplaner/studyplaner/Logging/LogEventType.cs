using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Studyplaner.UniversityStuff
{
    [Flags]
    public enum LogEventType
    {
        DEBUG = 0x001,
        WARNING = 0x010,
        ERROR = 0x100
    }
}
