using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Studyplaner.Logging.Targets
{
    public class FileLogTarget : ILogTarget
    {
        private string _fileName;

        public FileLogTarget(string fileName)
        {
            if (fileName == null)
                throw new ArgumentNullException("fileName");

            _fileName = fileName;
        }

        void ILogTarget.WriteToLog(string logEntry)
        {
            WriteToFile(logEntry);
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
                throw new LoggingException("There was an error writing to the file-log", ioEx);
            }
        }

        public override int GetHashCode()
        {
            return _fileName.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            FileLogTarget other = obj as FileLogTarget;

            if (other == null)
                return false;

            return (this.GetHashCode() == other.GetHashCode()) && (this._fileName == other._fileName);
        }
    }
}