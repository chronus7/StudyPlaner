using System;
using System.Collections.Generic;

namespace Studyplaner.UniversityStuff
{
    public class UniversityManager
    {
        private HashSet<ushort> _usedIDs;
        private Dictionary<ushort, University> _universities;

        public UniversityManager(string uniDirectory)
        {
            _usedIDs = new HashSet<ushort>();

            _universities = LoadUniversities(uniDirectory);
        }

        /// <summary>
        /// Generates the next valid ID for a new University
        /// </summary>
        /// <returns>The next ID if there is one, else -1</returns>
        private ushort GenerateNextID()
        {
            ushort s = 1;
            while (_usedIDs.Contains(s))
            {
                if (s < ushort.MaxValue)
                    s++;
                else
                    return 0;
            }
            return s;
        }

        /// <summary>
        /// Registers a new ID
        /// </summary>
        /// <param name="id">The ID to register</param>
        /// <returns>A value representing the success of the operation.
        ///     - true, if the id was added
        ///     - false oherwise</returns>
        private bool RegisterNewID(ushort id)
        {
            if (_usedIDs.Contains(id))
                return false;

            _usedIDs.Add(id);
            return true;
        }

        private Dictionary<ushort, University> LoadUniversities(string uniDirectory)
        {
            //TODO: |f| load universities from given path.. remember to add values to +_usedIDs;
            //by the way... do we really wanna it this way??

            return null;
        }

        /// <summary>
        /// Adds a University o the manager
        /// Get called at constrution time to build the initial University-List
        /// </summary>
        /// <param name="toAdd">Die Universität, die hinzugefügt werden soll</param>
        public void AddUniversity(University toAdd)         //TODO: might want to return the id of the added uni?
        {
            if (toAdd == null)
                throw new ArgumentNullException("toAdd");

        }

        public void RemoveUniversity(ushort id)
        {
            
        }

        public void AddModule(ushort uniID, UniversityModule module)
        {
            
        }

        public void RemoveModule(ushort uniID, uint moduleID)
        {

        }
    }
}