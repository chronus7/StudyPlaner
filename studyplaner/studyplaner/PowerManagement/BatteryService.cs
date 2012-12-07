using System;
using System.Timers;
using System.Windows.Forms;

namespace Studyplaner.PowerManagement
{
    /// <summary>
    /// Represents the batterypart of a pc or laptop.
    /// Provides information about the current state of the system and raises an event when something changes
    /// </summary>
    public class BatteryService
    {
        // Thresholds for BatteryState Calculations
        private const int BATTERYTHRESHOLD_EMPTY = 10;
        private const int BATTERYTHRESHOLD_LOW = 30;
        private const int BATTERYTHRESHOLD_MEDIUM = 60;
        private const int BATTERYTHRESHOLD_HIGH = 90;

        public event EventHandler<BatteryEventArgs> BatteryStateChanged;

        protected virtual void OnBatteryStateChanged(BatteryEventArgs e)
        {
            BatteryStateChanged.Raise(this, e);
            Logging.LoggingManager.LogEvent(Logging.LogEventType.DEBUG, "BatteryState changed: " + e.BatteryState);
            if(e.ChargingState == ChargingState.OnBattery)
                Logging.LoggingManager.LogEvent(Logging.LogEventType.DEBUG, "Battery remaining: " + e.BatteryRemaining);
        }

        private bool _isChargeable, _isCharging;
        private short _batteryState;
        private int _batteryRemaining;
        private System.Timers.Timer _timer;

        public BatteryService()
        {
            _isChargeable = (SystemInformation.PowerStatus.BatteryChargeStatus != BatteryChargeStatus.NoSystemBattery);

            if (IsChargeable())
            {
                _isCharging = false;
                _batteryState = -1;
                _batteryRemaining = -1;

                UpdateBatteryState();

                _timer = new System.Timers.Timer(30000d);
                _timer.AutoReset = true;
                _timer.Elapsed += UpdateBatteryStateOnTimerTick;
                _timer.Start();
            }
        }

        private void UpdateBatteryStateOnTimerTick(object sender, ElapsedEventArgs e)
        {
            UpdateBatteryState();
        }

        private void UpdateBatteryState()
        {
            bool isChargingNow = SystemInformation.PowerStatus.PowerLineStatus == PowerLineStatus.Online ? true : false; // TODO: PowerLineStatus.Unknown wird nicht behandelt und als !charging interpretiert ändern?
            short batteryStateNow = (short)Math.Floor(SystemInformation.PowerStatus.BatteryLifePercent * 100f);
            int batteryRemaining = SystemInformation.PowerStatus.BatteryLifeRemaining;

            if (_isCharging != isChargingNow || _batteryState != batteryStateNow || batteryRemaining != _batteryRemaining)
            {
                BatteryEventArgs args = new BatteryEventArgs() 
                { 
                    BatteryState = CalculateBatteryState(batteryStateNow), 
                    ChargingState = CalculateChargingState(isChargingNow), 
                    BatteryRemaining = CalculateBatteryRemaining(batteryRemaining) 
                };
                OnBatteryStateChanged(args);

                _isCharging = isChargingNow;
                _batteryState = batteryStateNow;
                _batteryRemaining = batteryRemaining;
            }
        }

        private BatteryState CalculateBatteryState(short batteryRemaining)
        {
            if (batteryRemaining <= BATTERYTHRESHOLD_EMPTY)
                return BatteryState.Empty;
            else if (batteryRemaining <= BATTERYTHRESHOLD_LOW)
                return BatteryState.Low;
            else if (batteryRemaining <= BATTERYTHRESHOLD_MEDIUM)
                return BatteryState.Medium;
            else if (batteryRemaining <= BATTERYTHRESHOLD_HIGH)
                return BatteryState.High;
            else
                return BatteryState.FullyCharged;
        }

        private ChargingState CalculateChargingState(bool isCharging)
        {
            return isCharging ? ChargingState.Charging : ChargingState.OnBattery;
        }

        private TimeSpan CalculateBatteryRemaining(int seconds)
        {
            return new TimeSpan((seconds / 3600), (seconds / 60 % 60), 0);
        }

        /// <summary>
        /// Gets a value wether the running computer has a chargeable battery
        /// </summary>
        /// <returns></returns>
        public bool IsChargeable()
        {
            return _isChargeable;
        }

        /// <summary>
        /// Gets the current ChargingState of the system
        /// </summary>
        /// <returns>A value of Enums.Chargingstate</returns>
        public ChargingState GetCurrentChargingState()
        {
            return CalculateChargingState(_isCharging);
        }

        /// <summary>
        /// Gets the current BatteryState of the system
        /// </summary>
        /// <returns>A value of Enums.BatteryState</returns>
        public BatteryState GetCurrentBatteryState()
        {
            return CalculateBatteryState(_batteryState);
        }

        /// <summary>
        /// Gets the current remaining time, until the battery runs out of power
        /// </summary>
        /// <returns>A Timespan representing the remaining time</returns>
        public TimeSpan GetCurrentRemainingTime()
        {
            return CalculateBatteryRemaining(_batteryRemaining);
        }
    }
}