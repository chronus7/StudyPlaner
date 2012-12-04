using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Studyplaner.Materials.UniversityStuff;

namespace Studyplaner.Manager
{
    public class UniversityManager
    {
        private List<int> _usedIDs;

        private Dictionary<int, University> _universities;

        public UniversityManager(string uniDirectory)
        {
            _usedIDs = new List<int>();

            _universities = LoadUniversities(uniDirectory);
        }

        public void foo(int[] values)
        {
            _usedIDs.AddRange(values);
        }

        public int GenerateNextID()
        {
            int id = -1;
            if (_usedIDs.Count == 0)
                id = 1;
            else
                id = FindNextID(0);
            _usedIDs.Add(id);
            return id;
        }

        private int FindNextID(int index)
        {
            if (_usedIDs.Count == (index + 1))
                return index + 2;
            if (_usedIDs[index] == -1)
                return ++index;

            return FindNextID(++index);
        }

        private Dictionary<int, University> LoadUniversities(string uniDirectory)
        {
            //TODO: |f| load universities from given path.. remember to increase _maxID;

            return null;
        }

        /// <summary>
        /// Fügt dem Manager eine Universität hinzu. 
        /// Im Kontruktor werden so die bereits vorhandenen Universitäten geladen
        /// </summary>
        /// <param name="toAdd">Die Universität, die hinzugefügt werden soll</param>
        public void AddUniversity(University toAdd)
        {

        }
 
    }
}
