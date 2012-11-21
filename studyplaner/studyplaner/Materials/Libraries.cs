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

        public UniLibrary get(int index)
        {
            return _list[index];
        }

        public void add(UniLibrary unilib)
        {
            //TODO | dj | maybe also file adding etc.
            _list.Add(unilib);
        }

        public UniLibrary this[int index]
        {
            get { return _list[index] }
            set; // TODO | dj | get makes sense. but set?!?!?
        }

        public IEnumerator<UniLibrary> GetEnumerator()
        {
            return _list.GetEnumerator();
        }
    }
}
