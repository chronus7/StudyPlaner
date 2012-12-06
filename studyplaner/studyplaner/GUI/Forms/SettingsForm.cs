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
    }
}
