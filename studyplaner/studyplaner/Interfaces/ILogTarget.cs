using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Studyplaner.Interfaces
{
    public interface ILogTarget
    {
        void SetTimeVisible(bool value);
        void WriteToLog(Enums.LogEventType eventType, string message);
    }
}
