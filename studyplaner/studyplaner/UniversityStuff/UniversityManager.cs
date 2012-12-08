using System;
using System.Collections.Generic;

namespace Studyplaner.UniversityStuff
{
    public static class UniversityManager
    {
        private const string ERROR_NOT_INITIALIZED = "The UniversityManager has not been correctly initialized! Call .Initialize() before using.";
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

        private static Dictionary<ushort, University> LoadUniversities(string uniDirectory)
        {
            //TODO: |f| load universities from given path.. remember to add values to +_usedIDs;
            //by the way... do we really wanna it this way??

            return null;
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
        /// Kinda weird i think but we use this way too often to write it all the time like this
        /// In public methods this should always be called first to ensure consistency
        /// </summary>
        private static void CheckInitialization()
        {
            if (!IsInitialized())
                throw new InvalidOperationException(ERROR_NOT_INITIALIZED);
        }

        /// <summary>
        /// Adds a University o the manager
        /// Gets called multiple times at constrution time to build the initial University-List
        /// </summary>
        /// <param name="toAdd">The University to add</param>
        public static ushort AddUniversity(University toAdd)         //TODO: might want to return the id of the added uni?
        {
            CheckInitialization();

            if (toAdd == null)
                throw new ArgumentNullException("toAdd");

            //TODO: |f| add the University ;)

            return (ushort)toAdd.ID;
        }

        public static University GetUniversity(ushort id)
        {
            CheckInitialization();

            if (ContainsUniversity(id))
                return _universities[id];

            return null;                    //TODO: return null or throw an exception?
        }

        public static void RemoveUniversity(ushort id)
        {
            CheckInitialization();
        }

        public static uint AddModule(ushort uniID, UniversityModule module)
        {
            CheckInitialization();

            return 0;
        }

        public static void RemoveModule(ushort uniID, uint moduleID)
        {
            CheckInitialization();
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
            return _universities.ContainsKey(id);
        }

        private static bool ContainsModule(uint id)
        {
            return _modules.ContainsKey(id);
        }

        private static bool ContainsEvent(ulong id)
        {
            return _events.ContainsKey(id);
        }
    }
}