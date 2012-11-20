using Studyplaner.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Forms;

namespace Studyplaner.Materials
{
    /// <summary>
    /// Represents the batterypart of a pc or laptop.
    /// Provides information about the current state of the system and raises an event when something changes
    /// </summary>
    public class LaptopBattery
    {
        // Grenzen für BatteryState Berechnungen
        private const int BATTERYTHRESHOLD_EMPTY = 10;
        private const int BATTERYTHRESHOLD_LOW = 30;
        private const int BATTERYTHRESHOLD_MEDIUM = 60;
        private const int BATTERYTHRESHOLD_HIGH = 90;

        public event EventHandler<BatteryEventArgs> BatteryStateChanged;

        protected virtual void OnBatteryStateChanged(BatteryEventArgs e)
        {
            BatteryStateChanged.Raise(this, e);
        }

        private bool _isCharging;
        private short _batteryState;        
        private System.Timers.Timer _timer;

        public LaptopBattery()
        {
            _isCharging = false;
            _batteryState = -1;

            UpdateBatteryState();

            _timer = new System.Timers.Timer(30000d);
            _timer.AutoReset = true;
            _timer.Elapsed += UpdateBatteryStateOnTimerTick;
            _timer.Start();
        }

        private void UpdateBatteryStateOnTimerTick(object sender, ElapsedEventArgs e)
        {
            UpdateBatteryState();
        }

        private void UpdateBatteryState()
        {
            bool isChargingNow = SystemInformation.PowerStatus.PowerLineStatus == PowerLineStatus.Online ? true : false; // TODO: PowerLineStatus.Unknown wird nicht behandelt und als !charging interpretiert ändern?
            short batteryStateNow = (short)Math.Floor(SystemInformation.PowerStatus.BatteryLifePercent * 100f);

            if (_isCharging != isChargingNow || _batteryState != batteryStateNow)
            {
                BatteryEventArgs args = new BatteryEventArgs() { BatteryState = CalculateBatteryState(batteryStateNow), ChargingState = CalculateChargingState(isChargingNow) };
                OnBatteryStateChanged(args);

                _isCharging = isChargingNow;
                _batteryState = batteryStateNow;
            }

            // SystemInformation.PowerStatus.BatteryChargeStatus == BatteryChargeStatus.NoSystemBattery 
            // TODO: bisher gibt die Methode auf Desktoprechnern leere Batterie aus ansonsten könnte man diese Property checken, aber dann müsste die Struktur geändert werden
        }

        private BatteryState CalculateBatteryState(short batteryRemaining)
        {
            if (batteryRemaining <= BATTERYTHRESHOLD_EMPTY)                  // TODO: eventuell ranges anpassen.. btw: das geht nicht mit switch, weil man da keine ranges verwenden kann ;)
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
    }
}
