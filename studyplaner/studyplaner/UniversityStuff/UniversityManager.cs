using System;
using System.Collections.Generic;

namespace Studyplaner.UniversityStuff
{
    public static class UniversityManager
    {
        private const ulong MAXSIZE_UNIVERSITY  = 10000;
        private const ulong MAXSIZE_MODULE = 1000000000;
        private const ulong MAXSIZE_EVENT = 100000000000;

        private static Dictionary<ushort, University> _universities;
        private static Dictionary<uint, UniversityModule> _modules;
        private static Dictionary<ulong, UniversityEvent> _events;

        private static bool _initialized = false;

        /// <summary>
        /// Initializes the UniversityManager and loads all previously persisted data from xmls
        /// </summary>
        public static void Initialize()
        {
            _universities = new Dictionary<ushort, University>();
            _modules = new Dictionary<uint, UniversityModule>();
            _events = new Dictionary<ulong, UniversityEvent>();

            // TODO: deserialize values with path from settings

            _initialized = true;
        }

        /// <summary>
        /// Returns a value wether the UniversityManager has been correctly initialized
        /// </summary>
        /// <returns>Has the UniversityManager been correctly initialized?</returns>
        public static bool IsInitialized()
        {
            return _initialized;
        }

        /// <summary>
        /// Generates the next valid ID for a new University
        /// </summary>
        /// <returns>The next ID if there is one, else -1</returns> //TODO: change to fit
        private static ushort GenerateNextID()
        {
            ushort s = 1;
            //while (_usedIDs.Contains(s))
            //{
            //    if (s < ushort.MaxValue)
            //        s++;
            //    else
            //        return 0;
            //}
            return s;
        }

        /// <summary>
        /// Registers a new ID
        /// </summary>
        /// <param name="id">The ID to register</param>
        /// <returns>A value representing the success of the operation.
        ///     - true, if the id was added
        ///     - false otherwise</returns>
        private static bool RegisterNewID(ushort id)       // might want to put that together with adding
        {
            //if (_usedIDs.Contains(id))
            //    return false;

            //_usedIDs.Add(id);
            //return true;
            return false;
        }

        private static bool IsValidID(ulong id)
        {
            if (id > MAXSIZE_EVENT)
                return false;

            if (id < MAXSIZE_UNIVERSITY)
                return ContainsUniversity((ushort)id);

            if (id < MAXSIZE_MODULE)
                return ContainsModule((uint)id);

            return ContainsEvent(id);
        }

        private static bool ContainsUniversity(ushort id)
        {
            foreach (ushort key in _universities.Keys)
            {
                if (id == key)
                    return true;
            }

            return false;
        }

        private static bool ContainsModule(uint id)
        {
            foreach (uint key in _modules.Keys)
            {
                if (id == key)
                    return true;
            }

            return false;
        }

        private static bool ContainsEvent(ulong id)
        {
            foreach (ulong key in _events.Keys)
            {
                if (id == key)
                    return true;
            }

            return false;
        }

        private static Dictionary<ushort, University> LoadUniversities(string uniDirectory)
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
        public static void AddUniversity(University toAdd)         //TODO: might want to return the id of the added uni?
        {
            if (toAdd == null)
                throw new ArgumentNullException("toAdd");

        }

        public static void RemoveUniversity(ushort id)
        {
            
        }

        public static void AddModule(ushort uniID, UniversityModule module)
        {
            
        }

        public static void RemoveModule(ushort uniID, uint moduleID)
        {

        }
    }
}