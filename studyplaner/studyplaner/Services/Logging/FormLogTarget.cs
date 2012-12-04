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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        void ILogTarget.SetTimeVisible(bool value)
        {
            _writeTime = value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="eventType"></param>
        /// <param name="message"></param>
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
    }
}
