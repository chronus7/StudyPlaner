using System;
using System.Drawing;
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
            _btnColorExercises.BackColor = Properties.Settings.Default.USER_COLOR_EXERCISE;
            _btnColorInternships.BackColor = Properties.Settings.Default.USER_COLOR_INTERNSHIP;
            _btnColorTutorials.BackColor = Properties.Settings.Default.USER_COLOR_TUTORIAL;
            _btnColorCustoms.BackColor = Properties.Settings.Default.USER_COLOR_CUSTOM;
        }

        private void initLogInfo()
        {
            _ckBoxOutputConsole.Checked = Properties.Settings.Default.USER_LOGGING_TOCONSOLE;
            _ckBoxOutputFile.Checked = Properties.Settings.Default.USER_LOGGING_TOFILE;
            _ckBoxTime.Checked = Properties.Settings.Default.USER_LOGGING_WRITETIME;
            _txBoxOutputFile.Text = Properties.Settings.Default.USER_LOGGING_PATH;
            _ckBoxTime.Enabled = Properties.Settings.Default.USER_LOGGING_ENABLED;
            _txBoxOutputFile.Enabled = Properties.Settings.Default.USER_LOGGING_TOFILE;
        }

        private void initPath()
        {
            _txBoxDatapath.Text = Properties.Settings.Default.USER_DATAPATH;
        }

        private void ChangeColorClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                DialogResult dr = this._colorDialog.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    // selected colour
                    Color c = _colorDialog.Color;

                    if (btn == _btnBgColor)
                    {
                        Properties.Settings.Default.USER_COLOR_BACKGROUND = c;
                        changeMainBgColor();
                    }
                    else
                    {
                        if (btn == _btnColorLecture)
                            Properties.Settings.Default.USER_COLOR_LECTURE = c;
                        else if (btn == _btnColorExercises)
                            Properties.Settings.Default.USER_COLOR_EXERCISE = c;
                        else if (btn == _btnColorInternships)
                            Properties.Settings.Default.USER_COLOR_INTERNSHIP = c;
                        else if (btn == _btnColorTutorials)
                            Properties.Settings.Default.USER_COLOR_TUTORIAL = c;
                        else// if (btn == _btnColorCustoms)
                            Properties.Settings.Default.USER_COLOR_CUSTOM = c;
                        changeEventColors();
                    }
                }
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

        private void Output_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox ckBox = sender as CheckBox;
            if (ckBox != null)
            {
                if (ckBox == _ckBoxOutputConsole)
                    Properties.Settings.Default.USER_LOGGING_TOCONSOLE = ckBox.Checked;
                else // if (ckBox == _ckBoxOutputFile)
                {
                    _txBoxOutputFile.Enabled = ckBox.Checked;
                    Properties.Settings.Default.USER_LOGGING_TOFILE = ckBox.Checked;
                }
                bool enabled = (_ckBoxOutputFile.Checked || _ckBoxOutputConsole.Checked);
                _ckBoxTime.Enabled = enabled;
                Properties.Settings.Default.USER_LOGGING_ENABLED = enabled;
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

        private void WriteTime_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox ckBox = sender as CheckBox;
            if (ckBox != null)
            {
                Properties.Settings.Default.USER_LOGGING_WRITETIME = ckBox.Checked;
            }
        }
    }
}
