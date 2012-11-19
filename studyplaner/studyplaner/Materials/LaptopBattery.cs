using Studyplaner.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Forms;

namespace Studyplaner.Materials
{
    public class LaptopBattery
    {
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
            short batteryStateNow = (short)Math.Floor(SystemInformation.PowerStatus.BatteryLifePercent);

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
            if (batteryRemaining < 10)                  // TODO: eventuell ranges anpassen.. btw: das geht nicht mit switch, weil man da keine ranges verwenden kann ;)
                return BatteryState.Empty;
            else if (batteryRemaining < 30)
                return BatteryState.Low;
            else if (batteryRemaining < 60)
                return BatteryState.Medium;
            else if (batteryRemaining < 90)
                return BatteryState.High;
            else
                return BatteryState.FullyCharged;
        }

        private ChargingState CalculateChargingState(bool isCharging)
        {
            return isCharging ? ChargingState.Charging : ChargingState.OnBattery;
        }
 
        public ChargingState GetCurrentChargingState()
        {
            return CalculateChargingState(_isCharging);
        }

        public BatteryState GetCurrentBatteryState()
        {
            return CalculateBatteryState(_batteryState);
        }
    }
}
