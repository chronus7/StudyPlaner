using Studyplaner.Enums;
using System;

namespace Studyplaner.Various.EventArgs
{
    /// <summary>
    /// Provides additional information about the power state of the pc at eventtime.
    /// </summary>
    public class BatteryEventArgs : System.EventArgs
    {
        public BatteryState BatteryState { get; set; }
        public ChargingState ChargingState { get; set; }
        public TimeSpan BatteryRemaining { get; set; }
    }
}