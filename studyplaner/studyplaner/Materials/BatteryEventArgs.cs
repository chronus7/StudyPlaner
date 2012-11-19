using Studyplaner.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Studyplaner.Materials
{
    public class BatteryEventArgs : EventArgs
    {
        public BatteryState BatteryState { get; set; }
        public ChargingState ChargingState { get; set; }
    }
}
