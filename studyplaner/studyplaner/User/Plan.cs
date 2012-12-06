using Studyplaner.UniversityStuff;
using System;
using System.Collections.Generic;

namespace Studyplaner.User
{
    public class Plan
    {
        public String Name { get; set; }
        public List<UniversityEvent> Events { get; set; }
    }
}