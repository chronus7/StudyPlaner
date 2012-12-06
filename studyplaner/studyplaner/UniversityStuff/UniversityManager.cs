using System.Collections.Generic;

namespace Studyplaner.UniversityStuff
{
    public class UniversityManager
    {
        private HashSet<int> _usedIDs;

        private Dictionary<int, University> _universities;

        public UniversityManager(string uniDirectory)
        {
            _usedIDs = new HashSet<int>();

            _universities = LoadUniversities(uniDirectory);
        }

        public void foo(int[] values)
        {

        }

        /// <summary>
        /// Generates the next valid ID for a new University
        /// </summary>
        /// <returns>The next ID if there is one, else -1</returns>
        public int GenerateNextID()
        {
            int i = 1;
            while (_usedIDs.Contains(i))
            {
                if (i < int.MaxValue)
                    i++;
                else
                    return -1;
            }
            return i;
        }

        /// <summary>
        /// Registers a new ID
        /// </summary>
        /// <param name="id">The ID to register</param>
        /// <returns>A value representing the success of the operation.
        ///     - true, if the id was added
        ///     - false oherwise</returns>
        public bool RegisterNewID(int id)
        {
            if (_usedIDs.Contains(id))
                return false;

            _usedIDs.Add(id);
            return true;
        }

        private Dictionary<int, University> LoadUniversities(string uniDirectory)
        {
            //TODO: |f| load universities from given path.. remember to add values to +_usedIDs;

            return null;
        }

        /// <summary>
        /// Adds a University o the manager
        /// Get called at constrution time to build the initial University-List
        /// </summary>
        /// <param name="toAdd">Die Universität, die hinzugefügt werden soll</param>
        public void AddUniversity(University toAdd)
        {

        }
 
    }
}