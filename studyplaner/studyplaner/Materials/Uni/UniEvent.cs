using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Studyplaner.Enums;
using Studyplaner.Values;

namespace Studyplaner.Materials.Uni
{
    public class UniEvent
    {
        public int ID { get; set; }
        public int ModuleID { get; set; }
        public string LVNum { get; set; }
        public string Location { get; set; }
        public Time StartTime { get; set; }
        public Time EndTime { get; set; }
        public string Lecturer { get; set; }
        public int Importance { get; set; }
        public bool Power { get; set; }
        public EventType Type { get; set; }
    }
}
