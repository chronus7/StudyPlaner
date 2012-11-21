using Studyplaner.Materials.Uni;
using System;
using System.Collections.Generic;

namespace Studyplaner.Materials
{
    public class Plan
    {
        public String Name { get; set; }
        public List<UniEvent> Events { get; set; }
    }
}