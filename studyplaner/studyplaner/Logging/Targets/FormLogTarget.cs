using Studyplaner.GUI.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Studyplaner.Logging.Targets
{
    public class FormLogTarget : ILogTarget
    {
        private LogForm _logForm;

        /// <summary>
        /// Creates a new FormLogTarget which creates its own LogForm to show the Log in
        /// </summary>
        public FormLogTarget()
        {
            _logForm = new LogForm();
        }

        /// <summary>
        /// Secures that the created LogForm gets disposed, when our LogFormTarget gets destroyed
        /// We might not actually need this..^^
        /// </summary>
        ~FormLogTarget()
        {
            if (_logForm != null)
                _logForm.Dispose();
        }

        void ILogTarget.WriteToLog(string logEntry)
        {
            if (!_logForm.Visible)
                _logForm.Show();

            _logForm.AddLogEntry(logEntry);
        }

        public override int GetHashCode()
        {
            return _logForm.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            FormLogTarget other = obj as FormLogTarget;

            if (other == null)
                return false;

            return (this.GetHashCode() == other.GetHashCode());
        }
    }
}
