using Studyplaner.Materials.Uni;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Studyplaner.Materials
{
    public class Plan
    {
        public String Name { get; set; }
        public List<UniEvent> Events { get; set; }
    }
}
