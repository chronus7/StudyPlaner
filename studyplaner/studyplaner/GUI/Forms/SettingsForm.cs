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
        }

        private void changeMainBgColor()
        {
            this.BackColor = Properties.Settings.Default.USER_COLOR_BACKGROUND;
            _btnBgColor.BackColor = Properties.Settings.Default.USER_COLOR_BACKGROUND;
        }

        private void ChangeColorClick(object sender, EventArgs e)
        {
            DialogResult dr = this._colorDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Properties.Settings.Default.USER_COLOR_BACKGROUND = this._colorDialog.Color;
                changeMainBgColor();
            }
        }
    }
}
