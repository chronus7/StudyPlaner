﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Studyplaner.Enums;

namespace Studyplaner.Materials
{
    public class UniEvent
    {
        public int ID { get; set; }
        public int ParentID { get; set; }
        public string LVNum { get; set; }
        public string Location { get; set; }
        public string Lecturer { get; set; }
        public int Importance { get; set; }
        public bool Power { get; set; }
        //TODO time???
        public EventType Type { get; set; }
    }
}
