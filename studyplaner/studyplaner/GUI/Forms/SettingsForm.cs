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
            _fileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            initPath();
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

        private void initPath()
        {
            _txBoxDatapath.Text = Properties.Settings.Default.USER_DATAPATH;
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
            changeEventColors();
            initLogInfo();
            initPath();
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

        private void OutputFile_Click(object sender, EventArgs e)
        {
            TextBox txBox = sender as TextBox;
            if (txBox != null)
            {
                if (_fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    txBox.Text = _fileDialog.FileName;
                }
            }
        }

        private void Datapath_Click(object sender, EventArgs e)
        {
            TextBox txBox = sender as TextBox;
            if (txBox != null)
            {
                if (_folderDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    txBox.Text = _folderDialog.SelectedPath;
                }
            }
        }
    }
}
