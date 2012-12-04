using Studyplaner.GUI.Forms;
using Studyplaner.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Studyplaner.Services.Logging
{
    public class FormLogTarget : ILogTarget
    {
        private bool _writeTime;
        private StringBuilder _builder;

        private ReadOnlyListBox _output;

        public FormLogTarget()
        {
            _writeTime = true;
            LogForm form = new LogForm();
            _output = form.GetOutput();

            form.Show();
        }

        /// <summary>
        /// Secures that the created LogForm gets disposed, when our LogFormTarget gets destroyed
        /// We might not actaully need this..^^
        /// </summary>
        ~FormLogTarget()
        {
            if (_output != null && _output.FindForm() != null)
                _output.FindForm().Dispose();
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

            _output.Items.Add(_builder.ToString());
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
