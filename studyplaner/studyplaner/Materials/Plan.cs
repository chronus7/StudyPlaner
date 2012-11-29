using Studyplaner.Materials.University;
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