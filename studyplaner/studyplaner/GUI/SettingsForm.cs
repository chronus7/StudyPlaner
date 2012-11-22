﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Studyplaner.GUI
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
            this.BackColor = Properties.Settings.Default.COLOR_USER_BACKGROUND;
            _btnBgColor.BackColor = Properties.Settings.Default.COLOR_USER_BACKGROUND;
        }
    }
}