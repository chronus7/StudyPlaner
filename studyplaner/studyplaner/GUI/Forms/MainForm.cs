using System;
using System.Drawing;
using System.Windows.Forms;
using Studyplaner.GUI.Controls;
using Studyplaner.Logging;
using Studyplaner.Logging.Targets;
using Studyplaner.PowerManagement;
using Studyplaner.UniversityStuff;
using Studyplaner.UniversityStuff.Enums;

namespace Studyplaner.GUI.Forms
{
    public partial class MainForm : Form
    {
        private const float MAINPANEL_YDISTANCE_FACTOR = 0.68f; //TODO | dj | maybe we should change this ration?
                                                                //            the infopanel seems to get really big
                                                                //            in fullscreen mode
        private const string TOOLTIP_BATTERYLIFE = "Time remaining: ";

        private BatteryService _batteryService;

        public MainForm()
        {
            InitializeComponent();

            Initialize();
        }

        // kill me pleaase!
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

        private void Initialize()
        {
            LoggingManager.Initialize();

            this.BackColor = Properties.Settings.Default.USER_COLOR_BACKGROUND;

            this._panelMain.Paint += new PaintEventHandler(PaintMainPanel);

            InitializeDateTimeTimer();
            InitializeBattery();
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
                this._statusElementBattery.ToolTipText = string.Empty;
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
            this._statusElementDateTime.Text = DateTime.Now.ToLongDateString() + "   " + DateTime.Now.ToShortTimeString(); // "\t" will irgendwie nicht richtig, daher die spaces
            LoggingManager.LogEvent(Logging.LogEventType.DEBUG, "Statusbar time updated to: " + DateTime.Now.ToShortTimeString());                                                       
        }

        private void UpdateStatusBarBatteryState(BatteryState batteryState)
        {
            Image previous = _statusElementBattery.Image, next = null;

            switch (batteryState)
            {
                case BatteryState.Empty:
                    next = Properties.Resources.BATTERY_EMPTY;
                    break;
                case BatteryState.Low:
                    next = Properties.Resources.BATTERY_LOW;
                    break;
                case BatteryState.Medium:
                    next = Properties.Resources.BATTERY_MEDIUM;
                    break;
                case BatteryState.High:
                    next = Properties.Resources.BATTERY_HIGH;
                    break;
                case BatteryState.FullyCharged:
                    next = Properties.Resources.BATTERY_FULLYCHARGED;
                    break;
            }

            if (previous == null)
            {
                this._statusElementBattery.Image = next;
                LoggingManager.LogEvent(LogEventType.DEBUG, "Initialized BatteryState icon to: " + batteryState.ToString());
            }
            else if (previous != next)
            {
                this._statusElementBattery.Image = next;
                LoggingManager.LogEvent(LogEventType.DEBUG, "Updated BatteryState icon to: " + batteryState.ToString());
            }
        }

        private void UpdateBatteryToolTipText(TimeSpan batteryLifeRemaining)
        {
            this._statusElementBattery.ToolTipText  = TOOLTIP_BATTERYLIFE + batteryLifeRemaining.Hours.ToString("D2") + ':' + batteryLifeRemaining.Minutes.ToString("D2");
        }

        private void LaunchSettingsDialog()
        {
            LoggingManager.LogEvent(LogEventType.DEBUG, "Launching settings dialog.");
            SettingsForm settingsFrm = new SettingsForm();
            if (settingsFrm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Properties.Settings.Default.Save(); // will be saved in C:\Users\xxx\AppData\Low\Studyplaner\...
                // TODO | dj | here should be more... (method extraction) :P
                this.BackColor = Properties.Settings.Default.USER_COLOR_BACKGROUND;
                //LoggingManager.Initialize(); TODO | dj | shall reinitialize the Logging, but the Form still remains -.-'
                                            // and after the second form an exc. raises...
                LoggingManager.LogEvent(LogEventType.DEBUG, "Updated properties");
            }
            else
            {
                Properties.Settings.Default.Reload();
                LoggingManager.LogEvent(LogEventType.DEBUG, "Settings-window canceled and reloaded properties.");
            }
        }

        private void LaunchModuleDialog()
        {
            LoggingManager.LogEvent(LogEventType.DEBUG, "Launching new module dialog.");
            
            UniversitySelectForm usf = new UniversitySelectForm();
            if (usf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                LoggingManager.LogEvent(LogEventType.DEBUG, "University selected: " + usf.SelectedUniversity.ID);
                EditUniModuleForm moduleForm = new EditUniModuleForm(usf.SelectedUniversity.ID);
                if (moduleForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    LoggingManager.LogEvent(LogEventType.DEBUG, "New Module created.");
                    // refreshing. see todo in EditModuleForm
                }
                else
                    LoggingManager.LogEvent(LogEventType.DEBUG, "Creation of a new module aborted.");
            }
            else
                LoggingManager.LogEvent(LogEventType.DEBUG, "University selection canceled.");
            
        }

        private void DateTimeTimer_Tick(object sender, EventArgs e)
        {
            UpdateStatusBarDateTime();
        }

        private void OnBatteryStateChanged(object sender, BatteryEventArgs e)
        {
            UpdateStatusBarBatteryState(e.BatteryState);        // TODO: might want to save this state and compare to save time 
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
            //TestEventPanel();         //TODO: implement properly
        }

        private void _mainMenu_file_new_module_Click(object sender, EventArgs e)
        {
            LaunchModuleDialog();
        }
    }
}