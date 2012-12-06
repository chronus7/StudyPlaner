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
        public LogForm()
        {
            InitializeComponent();

            InitializeLogView();
        }

        private void InitializeLogView()
        {

        }

        public ReadOnlyListBox GetOutput()
        {
            return this.roBxLog;
        }

        private void LogForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }    
    }
}
