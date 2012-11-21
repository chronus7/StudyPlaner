using Studyplaner.Enums;
using System;

namespace Studyplaner.Materials
{
    /// <summary>
    /// Provides additional information about the power state of the pc at eventtime.
    /// </summary>
    public class BatteryEventArgs : EventArgs
    {
        public BatteryState BatteryState { get; set; }
        public ChargingState ChargingState { get; set; }
        public int BatteryRemaining { get; set; }
    }
}