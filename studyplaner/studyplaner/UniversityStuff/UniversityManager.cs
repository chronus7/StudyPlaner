using System;
using System.Collections.Generic;

namespace Studyplaner.UniversityStuff
{
    public static class UniversityManager
    {
        private const string ERROR_NOT_INITIALIZED = "The UniversityManager has not been correctly initialized! Call .Initialize() before using.";
        private const string ERROR_ID_OVERFLOW = "Cannot generate a new ID since there is a maximum reached of the requested type!";        // Not well formulated.
        private const ulong MAXSIZE_UNIVERSITY  = 10000;
        private const ulong MAXSIZE_MODULE = 1000000000;
        private const ulong MAXSIZE_EVENT = 100000000000;

        private static Dictionary<ushort, University> _universities;
        private static Dictionary<uint, UniversityModule> _modules;
        private static Dictionary<ulong, UniversityEvent> _events;

        public static bool Initialized { get; private set; }

        /// <summary>
        /// Initializes the UniversityManager and loads all previously persisted data from xmls
        /// </summary>
        public static void Initialize()
        {
            _universities = new Dictionary<ushort, University>();
            _modules = new Dictionary<uint, UniversityModule>();
            _events = new Dictionary<ulong, UniversityEvent>();

            // TODO: deserialize values with path from settings

            Initialized = true;
        }

        private static Dictionary<ushort, University> LoadUniversities(string uniDirectory)
        {
            //TODO: |f| load universities from given path.. remember to add values to +_usedIDs;
            //by the way... do we really wanna it this way??

            return null;
        }

        /// <summary>
        /// Kinda weird i think but we use this way too often to write it all the time like this
        /// In public methods this should always be called first to ensure consistency
        /// </summary>
        private static void CheckInitialization()
        {
            if (!Initialized)
                throw new InvalidOperationException(ERROR_NOT_INITIALIZED);
        }

        /// <summary>
        /// Adds a University o the manager
        /// Gets called multiple times at constrution time to build the initial University-List
        /// </summary>
        /// <param name="toAdd">The University to add</param>
        /// <returns>The ID that was used to add the University</returns>
        public static ushort AddUniversity(University toAdd)         //TODO: might want to return the id of the added uni?
        {
            CheckInitialization();

            if (toAdd == null)
                throw new ArgumentNullException("toAdd");

            ushort newID = (ushort)toAdd.ID; //TODO: need to change the id fields in the classes to the proper type
            if (ContainsUniversity(newID))
                newID = GenerateNewID();

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

            _universities.Remove(id);       //TODO: can be called even if the key doesnt exist.. do we want to do nothing or throw an exception?
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

        public static bool IsValidID(ulong id)
        {
            CheckInitialization();

            if (id > MAXSIZE_EVENT)
                return false;

            if (id < MAXSIZE_UNIVERSITY)
                return ContainsUniversity((ushort)id);

            if (id < MAXSIZE_MODULE)
                return ContainsModule((uint)id);

            return ContainsEvent(id);
        }

        private static ushort GenerateNewID()
        {
            ushort id = 1;
            while (ContainsUniversity(id))
            {
                if (id < ushort.MaxValue)
                    id++;
                else
                    throw new OverflowException(ERROR_ID_OVERFLOW);
            }

            return id;
        }

        private static uint GenerateNewID(ushort universityID)
        {
            return 0;
        }

        private static ulong GenerateNewID(uint moduleID)
        {
            return 0;
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