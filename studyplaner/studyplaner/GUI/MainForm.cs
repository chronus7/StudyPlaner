using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Studyplaner.GUI
{
    public partial class MainForm : Form
    {
        private const float MAINPANEL_YDISTANCE_FACTOR = 0.68f;

        public MainForm()
        {
            InitializeComponent();

            Initialize();
        }

        private void Initialize()
        {
            this.BackColor = Properties.Settings.Default.USER_BACKGROUND;
        }
            
        private void ResizePanels()
        {
            _panelMain.Size = new Size((int)(this.Size.Width * MAINPANEL_YDISTANCE_FACTOR), _panelMain.Size.Height);
            _panelInfo.Location = new Point(_panelMain.Location.X + _panelMain.Size.Width + 5, _panelInfo.Location.Y);
            _panelInfo.Size = new Size((int)(this.Size.Width * (1 - MAINPANEL_YDISTANCE_FACTOR)) - 45, _panelInfo.Height);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            ResizePanels();
        }

        private void totalQuitClick(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
