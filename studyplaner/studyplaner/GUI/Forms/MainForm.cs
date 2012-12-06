using Studyplaner.Enums;
using Studyplaner.GUI.Controls;
using Studyplaner.Materials.UniversityStuff;
using Studyplaner.Services;
using Studyplaner.Services.Logging;
using Studyplaner.Various.EventArgs;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Studyplaner.GUI.Forms
{
    public partial class MainForm : Form
    {
        private const float MAINPANEL_YDISTANCE_FACTOR = 0.68f; //TODO | dj | maybe we should change this ration?
                                                                //            the infopanel seems to get really big
                                                                //            in fullscreen mode
        private const string TOOLTIP_BATTERYLIFE = "Time remaining: ";

        private LogForm _logFrm;
        private SettingsForm _settingsFrm;

        private BatteryService _batteryService;

        private bool _loggingEnabled = false;

        public MainForm()
        {
            InitializeComponent();

            Initialize();
        }

        // kill us pleaase!
        private void TestEventPanel()
        {
            UniversityEvent ue = new UniversityEvent() { Type = EventType.Exercise };
            UniEventPanel panel = new UniEventPanel(ue);
            _panelMain.Controls.Add(panel);

            Timer t = new Timer();
            t.Interval = 5000;
            t.Tick += delegate(System.Object o, System.EventArgs e)
            {
                UniversityEvent newue = new UniversityEvent();
                int time = (int)DateTime.Now.Ticks;
                newue.Type = (time % 2 == 0) ? EventType.Lecture : EventType.Exercise; panel.EventToRepresent = newue;
            };
            t.Start();
        }

        private void TestLog()
        {
            if (_logFrm == null)
                _logFrm = new LogForm();
            else
                _logFrm.Show();

            Services.Logging.LoggingManager.SwitchTarget(new FormLogTarget());
            Services.Logging.LoggingManager.LogEvent(Enums.LogEventType.DEBUG, "test");
        }

        private void Initialize()
        {
            this.BackColor = Properties.Settings.Default.USER_COLOR_BACKGROUND;

            this._panelMain.Paint += new PaintEventHandler(PaintMainPanel);

            InitializeDateTimeTimer();
            InitializeBattery();
            InitializeLogging();
        }

        private void InitializeDateTimeTimer()
        {
            this._dateTimeTimer.Start();
            UpdateStatusBarDateTime();
        }

        private void InitializeBattery()
        {
            this._batteryService = new BatteryService();
            if (_batteryService.IsChargeable())
            {
                this._batteryService.BatteryStateChanged += OnBatteryStateChanged;
                UpdateStatusBarBatteryState(_batteryService.GetCurrentBatteryState());
                UpdateBatteryToolTipText(_batteryService.GetCurrentRemainingTime());
            }
            else
            {
                this._batteryService = null;
                this._statusElementBattery.Image = Properties.Resources.BATTERY_NOT_CHARGEABLE;
            }
        }


        private void InitializeLogging()
        {
            _loggingEnabled = Properties.Settings.Default.USER_LOG_ENABLED;

            if(_loggingEnabled)
            {
                if(_logFrm == null)
                    _logFrm = new LogForm();
                Services.Logging.LoggingManager.SwitchTarget(new FormLogTarget());
            }
        }


        private void ResizePanels()
        {
            _panelMain.Size = new Size((int)(this.Size.Width * MAINPANEL_YDISTANCE_FACTOR), _panelMain.Size.Height);
            _panelMain.Refresh(); //TODO | dj | not so nice...
            _panelInfo.Location = new Point(_panelMain.Location.X + _panelMain.Size.Width + 5, _panelInfo.Location.Y);
            _panelInfo.Size = new Size((int)(this.Size.Width * (1 - MAINPANEL_YDISTANCE_FACTOR)) - 40, _panelInfo.Height);
            _panelInfo.Refresh(); //TODO | f | not so nice as well...
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
            LoggingManager.LogEvent(LogEventType.DEBUG, "Updated BatteryState to " + batteryState.ToString());
        }

        private void UpdateBatteryToolTipText(TimeSpan batteryLifeRemaining)
        {
            this._statusElementBattery.ToolTipText = TOOLTIP_BATTERYLIFE + batteryLifeRemaining.Hours.ToString("D2") + ':' + batteryLifeRemaining.Minutes.ToString("D2");
        }

        private void LaunchSettingsDialog()
        {
            this._settingsFrm = new SettingsForm();
            if (_settingsFrm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Properties.Settings.Default.Save(); // will be saved in C:\Users\xxx\AppData\Low\Studyplaner\...
                // TODO | dj | here should be more... (method extraction) :P
                this.BackColor = Properties.Settings.Default.USER_COLOR_BACKGROUND;
            }
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

        private void PaintMainPanel(object sender, PaintEventArgs g)
        {
            PaintService.PaintGrid(g.Graphics);
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

        private void MainForm_Loaded(object sender, EventArgs e)
        {
            TestEventPanel();
            TestLog();
        }
    }
}