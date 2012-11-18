﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Studyplaner.Enums;

namespace Studyplaner.Materials
{
    public class UniModule
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Short { get; set; }
        public int UniID { get; set; }
        public Semester Semester { get; set; }
        public Department Department { get; set; }
        public List<UniEvent> Events { get; set; }
    }
}
