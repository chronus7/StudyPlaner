using Studyplaner.Enums;
using Studyplaner.Materials;
using Studyplaner.Services;
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
        private const string TOOLTIP_BATTERYLIFE = "Time remaining: ";

        private SettingsForm _settingsFrm;

        private LaptopBatteryService _batteryService;

        public MainForm()
        {
            InitializeComponent();

            Initialize();
        }

        private void Initialize()
        {
            this.BackColor = Properties.Settings.Default.COLOR_USER_BACKGROUND;

            this._dateTimeTimer.Start();
            UpdateStatusBarDateTime();

            this._batteryService = new LaptopBatteryService();
            this._batteryService.BatteryStateChanged += OnBatteryStateChanged;
            UpdateStatusBarBatteryState(_batteryService.GetCurrentBatteryState());
            UpdateBatteryToolTipText(_batteryService.GetCurrentRemainingTime());
        }

        private void ResizePanels()
        {
            _panelMain.Size = new Size((int)(this.Size.Width * MAINPANEL_YDISTANCE_FACTOR), _panelMain.Size.Height);
            _panelInfo.Location = new Point(_panelMain.Location.X + _panelMain.Size.Width + 5, _panelInfo.Location.Y);
            _panelInfo.Size = new Size((int)(this.Size.Width * (1 - MAINPANEL_YDISTANCE_FACTOR)) - 40, _panelInfo.Height);
        }

        private void UpdateStatusBarDateTime()
        {
            this._statusElementDateTime.Text = DateTime.Now.ToLongDateString() + "   " + DateTime.Now.ToShortTimeString(); // TODO: "\t" will irgendwie nicht richtig, daher die spaces
            // TODO: ergibt "Montag, 19. November 2012" nicht genau das, was wir wollten, aber die anderen Methoden sind schlechter und ich will den string nicht selber zusammenbauen                                                                    
        }

        private void UpdateStatusBarBatteryState(BatteryState batteryState)
        {
            Image img = null;

            switch (batteryState)
            {
                case BatteryState.Empty:
                    img = Properties.Resources.BATTERY_EMPTY;
                    break;
                case BatteryState.Low:
                    img = Properties.Resources.BATTERY_LOW;
                    break;
                case BatteryState.Medium:
                    img = Properties.Resources.BATTERY_MEDIUM;
                    break;
                case BatteryState.High:
                    img = Properties.Resources.BATTERY_HIGH;
                    break;
                case BatteryState.FullyCharged:
                    img = Properties.Resources.BATTERY_FULLYCHARGED;
                    break;
            }

            this._statusElementBattery.Image = img;
        }

        private void UpdateBatteryToolTipText(int batteryLifeRemaining)
        {
            byte hours = (byte)(batteryLifeRemaining / 3600);
            byte minutes = (byte)(batteryLifeRemaining / 60 % 60);

            this._statusElementBattery.ToolTipText = TOOLTIP_BATTERYLIFE + hours.ToString("D2") + ':' + minutes.ToString("D2");
        }

        private void LaunchSettingsDialog()
        {
            this._settingsFrm = new SettingsForm();
            if (_settingsFrm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                Properties.Settings.Default.Save();
            else
                Properties.Settings.Default.Reload();
        }

        private void dateTimeTimer_Tick(object sender, EventArgs e)
        {
            UpdateStatusBarDateTime();
        }

        private void OnBatteryStateChanged(object sender, BatteryEventArgs e)
        {
            UpdateStatusBarBatteryState(e.BatteryState);
            UpdateBatteryToolTipText(e.BatteryRemaining);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            ResizePanels();
        }

        private void TotalQuitClick(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void MenuItem_MouseEnter(object sender, EventArgs e)
        {
            ToolStripItem item = sender as ToolStripItem;

            if (item != null)
                this._statusElementTooltip.Text = item.ToolTipText;
        }

        private void MenuItem_MouseLeave(object sender, EventArgs e)
        {
            this._statusElementTooltip.Text = string.Empty;
        }

        private void OpenSettingsDialog(object sender, EventArgs e)
        {
            LaunchSettingsDialog();
        }
    }
}
