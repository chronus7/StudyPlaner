using Studyplaner.Materials.Uni;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Studyplaner.Materials
{
    public class Libraries
    {
        private List<UniLibrary> _list;

        public Libraries(List<UniLibrary> list)
        {
            _list = list;
        }

        public UniLibrary this[int index]
        {
            get { return _list[index]; }
            set { _list[index] = value; }//TODO | dj | maybe also file adding etc.
        }

        public IEnumerator<UniLibrary> GetEnumerator()
        {
            return _list.GetEnumerator();
        }
    }
}
