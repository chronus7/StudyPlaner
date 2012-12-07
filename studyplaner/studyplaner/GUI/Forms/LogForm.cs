using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Studyplaner.GUI.Forms
{
    public partial class LogForm : Form
    {
        delegate void AddLogEntryCallback(string message);

        public LogForm()
        {
            InitializeComponent();
        }

        private void InitializeLogView()
        {

        }

        /// <summary>
        /// Adds a LogEntry threadsafe to the LogForm
        /// </summary>
        /// <param name="entry"></param>
        public void AddLogEntry(string entry)
        {
            if (roBxLog.InvokeRequired)
            {
                AddLogEntryCallback callback = new AddLogEntryCallback(AddLogEntry);
                this.Invoke(callback, new object[] { entry });
            }
            else
            {
                this.roBxLog.Items.Add(entry);
                this.roBxLog.SelectedIndex = roBxLog.Items.Count - 1;
            }
        }

        private void LogForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }    
    }
}
