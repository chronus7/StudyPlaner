using Studyplaner.Enums;
using Studyplaner.Materials;
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
        private LaptopBattery _battery;

        public MainForm()
        {
            InitializeComponent();

            Initialize();
        }

        private void Initialize()
        {
            this.BackColor = Properties.Settings.Default.USER_BACKGROUND;

            this._dateTimeTimer.Start();
            UpdateStatusBarDateTime();

            this._battery = new LaptopBattery();
            this._battery.BatteryStateChanged += OnBatteryStateChanged;
            UpdateStatusBarBatteryState(_battery.GetCurrentBatteryState());
        }
            
        private void ResizePanels()
        {
            _panelMain.Size = new Size((int)(this.Size.Width * MAINPANEL_YDISTANCE_FACTOR), _panelMain.Size.Height);
            _panelInfo.Location = new Point(_panelMain.Location.X + _panelMain.Size.Width + 5, _panelInfo.Location.Y);
            _panelInfo.Size = new Size((int)(this.Size.Width * (1 - MAINPANEL_YDISTANCE_FACTOR)) - 45, _panelInfo.Height);
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
                    img = Properties.Resources.EMPTY;
                    break;
                case BatteryState.Low:
                    img = Properties.Resources.LOW;
                    break;
                case BatteryState.Medium:
                    img = Properties.Resources.MEDIUM;
                    break;
                case BatteryState.High:
                    img = Properties.Resources.HIGH;
                    break;
                case BatteryState.FullyCharged:
                    img = Properties.Resources.FULLYCHARGED;
                    break;
            }

            this._statusElementBattery.Image = img;
        }

        private void dateTimeTimer_Tick(object sender, EventArgs e)
        {
            UpdateStatusBarDateTime();
        }

        private void OnBatteryStateChanged(object sender, BatteryEventArgs e)
        {
            UpdateStatusBarBatteryState(e.BatteryState);
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
