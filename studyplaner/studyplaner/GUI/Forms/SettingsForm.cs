using System;
using System.Drawing;
using System.Windows.Forms;
using Studyplaner.Logging;

namespace Studyplaner.GUI.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            Initialize();

            LoggingManager.LogEvent(LogEventType.DEBUG, "Settingsform intialized and opened.");
        }

        private void Initialize()
        {
            ChangeGeneral();
            ChangeMainBgColor();
            ChangeEventColors();
            ChangeLoggings();
            _fileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        private void ChangeGeneral()
        {
            _txBox_datapath.Text = Properties.Settings.Default.USER_DATAPATH;
        }

        private void ChangeMainBgColor()
        {
            this.BackColor = Properties.Settings.Default.USER_COLOR_BACKGROUND;
            _btn_colorBG.BackColor = Properties.Settings.Default.USER_COLOR_BACKGROUND;
        }

        private void ChangeEventColors()
        {
            _btn_colorLectures.BackColor = Properties.Settings.Default.USER_COLOR_LECTURE;
            _btn_colorExercises.BackColor = Properties.Settings.Default.USER_COLOR_EXERCISE;
            _btn_colorInternships.BackColor = Properties.Settings.Default.USER_COLOR_INTERNSHIP;
            _btn_colorTutorials.BackColor = Properties.Settings.Default.USER_COLOR_TUTORIAL;
            _btn_colorCustoms.BackColor = Properties.Settings.Default.USER_COLOR_CUSTOM;
        }

        private void ChangeLoggings()
        {
            bool enabled = Properties.Settings.Default.USER_LOGGING_ENABLED;

            _chkBox_logging.Checked = enabled;
            
            _chkBox_toConsole.Checked = Properties.Settings.Default.USER_LOGGING_TOCONSOLE;
            _chkBox_toFile.Checked = Properties.Settings.Default.USER_LOGGING_TOFILE;
            _txBox_loggingpath.Text = Properties.Settings.Default.USER_LOGGING_PATH;
            _chkBox_writetime.Checked = Properties.Settings.Default.USER_LOGGING_WRITETIME;

            EnableAllFields(enabled);
            _txBox_loggingpath.Enabled = Properties.Settings.Default.USER_LOGGING_TOFILE && enabled;
        }

        private void EnableAllFields(bool enable)
        {
            _chkBox_toConsole.Enabled = enable;
            _chkBox_toFile.Enabled = enable;
            _txBox_loggingpath.Enabled = enable; 
            _chkBox_writetime.Enabled = enable;
        }

        // == KeyEvents == \\

        // -- 'globals' --

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            Initialize();
            LoggingManager.LogEvent(LogEventType.DEBUG, "Properties reset to default values.");
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();
            LoggingManager.LogEvent(LogEventType.DEBUG, "Settingsform closed; changes discarded.");
            this.Close();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            LoggingManager.LogEvent(LogEventType.DEBUG, "Settingsform closed; changes saved.");
            this.Close();
        }

        // -- General --

        private void DataPath_Click(object sender, EventArgs e)
        {
            DialogResult dialog = _folderDialog.ShowDialog();
            if (dialog == System.Windows.Forms.DialogResult.OK)
            {
                // TODO | dj | test
                Properties.Settings.Default.USER_DATAPATH = _folderDialog.SelectedPath;
                ChangeGeneral();
            }
        }

        // -- Colors --

        private void ChooseBackground_Click(object sender, EventArgs e)
        {
            _colorDialog.Color = Properties.Settings.Default.USER_COLOR_BACKGROUND;
            DialogResult result = _colorDialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                Properties.Settings.Default.USER_COLOR_BACKGROUND = _colorDialog.Color;
                ChangeMainBgColor();
            }
        }

        private void ChooseColor_Click(object sender, EventArgs e)
        {
            Button s = sender as Button;
            if (s == null)
                return;

            Enum evt = null;

            if (s == _btn_colorLectures)
                evt = UniversityStuff.Enums.EventType.Lecture;
            else if (s == _btn_colorExercises)
                evt = UniversityStuff.Enums.EventType.Exercise;
            else if (s == _btn_colorInternships)
                evt = UniversityStuff.Enums.EventType.Internship;
            else if (s == _btn_colorTutorials)
                evt = UniversityStuff.Enums.EventType.Tutorial;
            else if (s == _btn_colorCustoms)
                evt = UniversityStuff.Enums.EventType.Custom;
            
            if (evt is UniversityStuff.Enums.EventType)
                ChangeEventColor((UniversityStuff.Enums.EventType)evt);
        }

        private void ChangeEventColor(UniversityStuff.Enums.EventType type)
        {
            Color c;
            switch (type)
            {
                case Studyplaner.UniversityStuff.Enums.EventType.Lecture:
                    c = Properties.Settings.Default.USER_COLOR_LECTURE;
                    break;
                case Studyplaner.UniversityStuff.Enums.EventType.Exercise:
                    c = Properties.Settings.Default.USER_COLOR_EXERCISE;
                    break;
                case Studyplaner.UniversityStuff.Enums.EventType.Tutorial:
                    c = Properties.Settings.Default.USER_COLOR_TUTORIAL;
                    break;
                case Studyplaner.UniversityStuff.Enums.EventType.Internship:
                    c = Properties.Settings.Default.USER_COLOR_INTERNSHIP;
                    break;
                case Studyplaner.UniversityStuff.Enums.EventType.Custom:
                    c = Properties.Settings.Default.USER_COLOR_CUSTOM;
                    break;
                default:
                    c = new Color();
                    break;
            }
            _colorDialog.Color = c;
            DialogResult result = _colorDialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                c = _colorDialog.Color;
                switch (type)
                {
                    case Studyplaner.UniversityStuff.Enums.EventType.Lecture:
                        Properties.Settings.Default.USER_COLOR_LECTURE = c;
                        break;
                    case Studyplaner.UniversityStuff.Enums.EventType.Exercise:
                        Properties.Settings.Default.USER_COLOR_EXERCISE = c;
                        break;
                    case Studyplaner.UniversityStuff.Enums.EventType.Tutorial:
                        Properties.Settings.Default.USER_COLOR_TUTORIAL = c;
                        break;
                    case Studyplaner.UniversityStuff.Enums.EventType.Internship:
                        Properties.Settings.Default.USER_COLOR_INTERNSHIP = c;
                        break;
                    case Studyplaner.UniversityStuff.Enums.EventType.Custom:
                        Properties.Settings.Default.USER_COLOR_CUSTOM = c;
                        break;
                    default:
                        break;
                }
                ChangeEventColors();
            }
        }

        // -- Logging --

        private void EnableLogging_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.USER_LOGGING_ENABLED = _chkBox_logging.Checked;
            ChangeLoggings();
        }

        private void ToConsole_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.USER_LOGGING_TOCONSOLE = _chkBox_toConsole.Checked;
            ChangeLoggings();
        }

        private void ToFile_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.USER_LOGGING_TOFILE = _chkBox_toFile.Checked;
            ChangeLoggings();
        }

        private void WriteTime_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.USER_LOGGING_WRITETIME = _chkBox_writetime.Checked;
            ChangeLoggings();
        }

        private void LogPath_Click(object sender, EventArgs e)
        {
            DialogResult dialog = _fileDialog.ShowDialog();
            if (dialog == System.Windows.Forms.DialogResult.OK)
            {
                // TODO | dj | test
                Properties.Settings.Default.USER_LOGGING_PATH = _fileDialog.FileName;
                ChangeLoggings();
            }
        }

    }
}
