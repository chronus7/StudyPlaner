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
            initDataPath();
            changeMainBgColor();
            changeEventColors();
            changeLoggings();
            _fileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        private void initDataPath()
        {
            _txBox_datapath.Text = Properties.Settings.Default.USER_DATAPATH;
        }

        private void changeMainBgColor()
        {
            this.BackColor = Properties.Settings.Default.USER_COLOR_BACKGROUND;
            _btn_colorBG.BackColor = Properties.Settings.Default.USER_COLOR_BACKGROUND;
        }

        private void changeEventColors()
        {
            _btn_colorLectures.BackColor = Properties.Settings.Default.USER_COLOR_LECTURE;
            _btn_colorExercises.BackColor = Properties.Settings.Default.USER_COLOR_EXERCISE;
            _btn_colorInternships.BackColor = Properties.Settings.Default.USER_COLOR_INTERNSHIP;
            _btn_colorTutorials.BackColor = Properties.Settings.Default.USER_COLOR_TUTORIAL;
            _btn_colorCustoms.BackColor = Properties.Settings.Default.USER_COLOR_CUSTOM;
        }

        private void changeLoggings()
        {
            bool enabled = Properties.Settings.Default.USER_LOGGING_ENABLED;

            _chkBox_logging.Checked = enabled;
            
            _chkBox_toConsole.Checked = Properties.Settings.Default.USER_LOGGING_TOCONSOLE;
            _chkBox_toFile.Checked = Properties.Settings.Default.USER_LOGGING_TOFILE;
            _txBox_loggingpath.Text = Properties.Settings.Default.USER_LOGGING_PATH;
            _chkBox_writetime.Checked = Properties.Settings.Default.USER_LOGGING_WRITETIME;

            enableAllFields(enabled);
            _txBox_loggingpath.Enabled = Properties.Settings.Default.USER_LOGGING_TOFILE && enabled;
        }

        private void enableAllFields(bool enable)
        {
            _chkBox_toConsole.Enabled = enable;
            _chkBox_toFile.Enabled = enable;
            _txBox_loggingpath.Enabled = enable; 
            _chkBox_writetime.Enabled = enable;
        }

        // == KeyEvents == \\

        // -- Logging --

        private void EnableLogging_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.USER_LOGGING_ENABLED = _chkBox_logging.Checked;
            changeLoggings();
        }

        private void ToConsole_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.USER_LOGGING_TOCONSOLE = _chkBox_toConsole.Checked;
            changeLoggings();
        }

        private void ToFile_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.USER_LOGGING_TOFILE = _chkBox_toFile.Checked;
            changeLoggings();
        }

        private void WriteTime_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.USER_LOGGING_WRITETIME = _chkBox_writetime.Checked;
            changeLoggings();
        }

    }
}
