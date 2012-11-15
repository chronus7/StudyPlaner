using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudyPlaner
{
    public partial class MainFrm : Form
    {
        private DrawHelper _dHelper;
        private XMLParser _xParser;

        public MainFrm()
        {
            InitializeComponent();

            this._dHelper = new DrawHelper();
            this._xParser = new XMLParser();

            // Set the embedded icon
            this.Icon = Properties.Resources.Icon;
            this.trayIcon.Icon = Properties.Resources.Icon;

            this._dHelper.SelectedEventChanged += new EventHandler(_dHelper_SelectedEventChanged);
        }

        #region ## Tray Methods ##

        /// <summary>
        /// Hides the window and sends it to the systemtray
        /// </summary>
        private void MinimizeToTray()
        {
            this.ShowInTaskbar = false;
            this.Hide();
        }

        /// <summary>
        /// Shows the window again from the systemtray
        /// </summary>
        private void ShowFromTray(/*bool maximize?*/)
        {
            this.ShowInTaskbar = true;
            this.Show();
            this.Activate();
        }

        #endregion

        private void MainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //e.Cancel = true;

            //MinimizeToTray();
        }

        private void trayIcon_DoubleClick(object sender, EventArgs e)
        {
            ShowFromTray();
        }

        private void tlstrBtnFileQuitClick(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void MainFrm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                MinimizeToTray();
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                ShowFromTray();
            }
        }


        private void ctMenuTrayShow_Click(object sender, EventArgs e)
        {
            this.ShowFromTray();
        }

        private void ctMenuTrayClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void PanelPaint_Paint(object sender, PaintEventArgs e)
        {
            _dHelper.DrawBackground(e);
            foreach (Event ev in _xParser.getSelectedEvents())
            {
                _dHelper.DrawSingleEvent(ev, sender, e);
            }
        }


        private void _dHelper_SelectedEventChanged(object sender, EventArgs e)
        {
            if (_dHelper.SelectedEvent != null)
            {
                this.PanelDetails.Visible = true;
                this.lblDetailsModuleName.Text = _dHelper.SelectedEvent.ID;
            }
            else
                this.PanelDetails.Visible = false;
        }
    }
}