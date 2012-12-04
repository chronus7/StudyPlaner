using Studyplaner.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Studyplaner.Various.Exceptions;

namespace Studyplaner.Services.Logging
{
    public class FileLogTarget : ILogTarget
    {
        private bool _writeTime;
        private string _fileName;

        private StringBuilder _builder;

        public FileLogTarget(string fileName)
        {
            if (fileName == null)
                throw new ArgumentNullException("fileName");

            _fileName = fileName;
        }

        void ILogTarget.SetTimeVisible(bool value)
        {
            _writeTime = value;
        }

        void ILogTarget.WriteToLog(Enums.LogEventType eventType, string message)
        {
            if (_builder == null)
                _builder = new StringBuilder();
            else
                _builder.Clear();

            _builder.Append('[' + eventType.ToString() + ']');

            if (_writeTime)
                _builder.Append('[' + DateTime.Now.ToShortTimeString() + ']');
            else
                _builder.Append('\t');

            _builder.Append("\t" + message);

            WriteToFile(_builder.ToString());
        }

        private void WriteToFile(string message)
        {
            try
            {
                using (FileStream fs = new FileStream(_fileName, FileMode.Append, FileAccess.Write))
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(message);
                    sw.Flush();
                }
            }
            catch (IOException ioEx)
            {
                throw new LoggingException("There was an error writing to the file-log");
            }
        }
    }
}