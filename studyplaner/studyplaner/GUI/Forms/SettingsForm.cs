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
            _fileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
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

    }
}
