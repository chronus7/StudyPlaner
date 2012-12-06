using Studyplaner.GUI.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Studyplaner.Logging.Targets
{
    public class FormLogTarget : ILogTarget
    {
        private bool _writeTime;
        private StringBuilder _builder;

        private LogForm _logForm;
        private ReadOnlyListBox _output;

        /// <summary>
        /// Creates a new FormLogTarget which creates its own LogForm to show the Log in
        /// </summary>
        public FormLogTarget()
        {
            _writeTime = true;
            _logForm = new LogForm();
            _output = _logForm.GetOutput();
        }

        /// <summary>
        /// Secures that the created LogForm gets disposed, when our LogFormTarget gets destroyed
        /// We might not actaully need this..^^
        /// </summary>
        ~FormLogTarget()
        {
            if (_logForm != null)
                _logForm.Dispose();
        }

        void ILogTarget.SetTimeVisible(bool value)
        {
            _writeTime = value;
        }

        void ILogTarget.WriteToLog(LogEventType eventType, string message)
        {
            if (!_logForm.Visible)
                _logForm.Show();

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

            _output.Items.Add(_builder.ToString());
            _output.SelectedIndex = _output.Items.Count - 1;
        }

        public override int GetHashCode()
        {
            return _output.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            FormLogTarget other = obj as FormLogTarget;

            if (other == null)
                return false;

            return (this.GetHashCode() == other.GetHashCode()) && (this._writeTime == other._writeTime) && (this._output == other._output); // TODO: |f| not sure wether this is enough for List.Contains to work properly
        }
    }
}
