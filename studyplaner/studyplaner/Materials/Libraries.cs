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

        public IEnumerator<UniLibrary> GetEnumerator()
        {
            return _list.GetEnumerator();
        }
    }
}
