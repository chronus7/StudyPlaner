using Studyplaner.Materials.UniversityStuff;
using System;
using System.Collections.Generic;

namespace Studyplaner.Materials
{
    public class Plan
    {
        public String Name { get; set; }
        public List<UniversityEvent> Events { get; set; }
    }
}