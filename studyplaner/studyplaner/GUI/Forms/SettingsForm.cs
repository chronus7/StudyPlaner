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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            Initialize();
        }

        private void Initialize()
        {
            changeMainBgColor();
            changeEventColors();
            initLogInfo();
        }

        private void changeMainBgColor()
        {
            this.BackColor = Properties.Settings.Default.USER_COLOR_BACKGROUND;
            _btnBgColor.BackColor = Properties.Settings.Default.USER_COLOR_BACKGROUND;
        }

        private void changeEventColors()
        {
            _btnColorLecture.BackColor = Properties.Settings.Default.USER_COLOR_LECTURE;
        }

        private void initLogInfo()
        {
            _ckBoxLogging.Checked = Properties.Settings.Default.USER_LOG_ENABLED;
            _ckBoxOutputConsole.Checked = Properties.Settings.Default.USER_LOG_TOCONSOLE;
            _ckBoxOutputFile.Checked = Properties.Settings.Default.USER_LOG_TOFILE;
            _txBoxOutputFile.Text = Properties.Settings.Default.USER_LOG_PATH;
        }

        private void ChangeColorClick(object sender, EventArgs e)
        {
            // TODO | dj | generalize...
            DialogResult dr = this._colorDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Properties.Settings.Default.USER_COLOR_BACKGROUND = this._colorDialog.Color;
                changeMainBgColor();
            }
        }

        private void ResetClick(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            //TODO | dj | not only this...
            changeMainBgColor();
            Logging.LoggingManager.LogEvent(Logging.LogEventType.DEBUG, "Reset properties to default.");
        }

        private void Logging_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox ckBox = sender as CheckBox;
            if (ckBox != null)
            {
                setLogOutputVisible(ckBox.Checked);
            }
        }

        private void setLogOutputVisible(bool visible)
        {
            _lblOutput.Visible = visible;
            _ckBoxOutputConsole.Visible = visible;
            _ckBoxOutputFile.Visible = visible;
        }

        private void OutputFile_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox ckBox = sender as CheckBox;
            if (ckBox != null)
            {
                _txBoxOutputFile.Visible = ckBox.Checked;
            }
        }
    }
}
