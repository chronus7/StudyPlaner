using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Studyplaner.Materials.Uni
{
    public class UniLibrary
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Short { get; set; }
        public List<UniModule> Modules { get; set; }
    }
}
