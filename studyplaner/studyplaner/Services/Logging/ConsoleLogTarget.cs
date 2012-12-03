using Studyplaner.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Studyplaner.Services.Logging
{
    public class ConsoleLogTarget : ILogTarget
    {
        void ILogTarget.WriteToLog(string message)
        {
            Console.Out.WriteLine('[' + DateTime.Now.ToShortTimeString() + ']' + "\t" + message);
        }
    }
}
