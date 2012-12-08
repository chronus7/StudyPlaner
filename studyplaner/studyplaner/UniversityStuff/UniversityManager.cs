using System;
using System.Collections.Generic;

namespace Studyplaner.UniversityStuff
{
    public static class UniversityManager
    {
        private const string ERROR_NOT_INITIALIZED  = "The UniversityManager has not been correctly initialized! Call UniversityManager.Initialize() before using.";
        private const string ERROR_ID_OVERFLOW      = "Cannot generate a new ID since there is a maximum reached of the requested type!";        // Not well written ;)

        //TODO: We can save ram here by using the appropiate types
        private const ulong MAXSIZE_UNIVERSITY      = 10000;
        private const ulong MAXSIZE_MODULE          = 1000000000;
        private const ulong MAXSIZE_EVENT           = 100000000000;

        private const uint MULTIPLYER_UNIVERSITY    = 100000;
        private const uint MULTIPLYER_MODULE        = 100;

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
        /// Kinda weird i think, but we use this way too often to write it all the time like this
        /// In public methods this should always be called first to ensure consistency
        /// </summary>
        private static void CheckInitialization()
        {
            if (!Initialized)
                throw new InvalidOperationException(ERROR_NOT_INITIALIZED);
        }

        /// <summary>
        /// Adds a University o the UniversityManager
        /// Gets called multiple times at constrution time to build the initial University-List
        /// </summary>
        /// <param name="toAdd">The University to add</param>
        /// <returns>The ID that was used to add the University</returns>
        public static ushort AddUniversity(University toAdd)
        {
            CheckInitialization();

            if (toAdd == null)
                throw new ArgumentNullException("toAdd");

            ushort newID = (ushort)toAdd.ID;                        //TODO: need to change the id fields in the classes to the proper type
            if (!IsValidID(newID) || ContainsUniversity(newID))
                newID = GenerateNewID();

            toAdd.ID = newID;
            _universities.Add(newID, toAdd);

            return (ushort)toAdd.ID;
        }

        /// <summary>
        /// Gets the University with the given ID from the UniversityManager
        /// </summary>
        /// <param name="uniID">The ID of the University to get</param>
        /// <returns>The University if it is in the manager, null if not</returns>
        public static University GetUniversity(ushort uniID)
        {
            CheckInitialization();

            if (ContainsUniversity(uniID))
                return _universities[uniID];

            return null;                    //TODO: return null or throw an exception?
        }

        /// <summary>
        /// Removes a University from the UniversityManager
        /// </summary>
        /// <param name="uniID">The ID of the University to remove</param>
        public static void RemoveUniversity(ushort uniID)
        {
            CheckInitialization();

            _universities.Remove(uniID);       //TODO: can be called even if the key doesnt exist.. do we want to do nothing or throw an exception?
        }

        /// <summary>
        /// Adds a Module to the UniversityManager
        /// </summary>
        /// <param name="uniID">The ID of the University to which the UniversityModule belongs</param>
        /// <param name="toAdd">The Module to add</param>
        /// <returns>The ID that was used to add the University</returns>
        public static uint AddModule(ushort uniID, UniversityModule toAdd)
        {
            CheckInitialization();

            return 0;
        }

        /// <summary>
        /// Gets a Module with the given ID from the UniversityManager
        /// </summary>
        /// <param name="moduleID">The ID of the UniversityModule to get</param>
        /// <returns>The UniversityModule if it is in the Manager. null if not</returns>
        public static UniversityModule GetModule(uint moduleID)
        {
            CheckInitialization();

            return null;            //TODO: haha
        }

        /// <summary>
        /// Removes a Module from the UniversityManager
        /// </summary>
        /// <param name="uniID"></param>
        /// <param name="moduleID"></param>
        public static void RemoveModule(uint moduleID)
        {
            CheckInitialization();

            //TODO: REmove the module
        }

        private static bool IsValidID(ulong id)
        {
            ushort uni = (ushort)(id / (MULTIPLYER_UNIVERSITY * MULTIPLYER_MODULE));
            uint module = (uint)(id % (MULTIPLYER_UNIVERSITY * MULTIPLYER_MODULE) / MULTIPLYER_MODULE);
            ulong evnt = id % MULTIPLYER_MODULE;

            return (IsValidID(uni) && IsValidID(module) && (evnt > 0) && (evnt < MULTIPLYER_MODULE));
        }

        private static bool IsValidID(uint id)
        {
            ushort uni = (ushort)(id / MULTIPLYER_UNIVERSITY);
            uint module = id % MULTIPLYER_UNIVERSITY;

            return (IsValidID(uni) && (module > 0 && module < MULTIPLYER_UNIVERSITY));
        }

        private static bool IsValidID(ushort id)
        {
            return (id > 0) && (id < MAXSIZE_UNIVERSITY);
        }

        /// <summary>
        /// Returns wether the UniversityManager contains an Item with the given ID
        /// </summary>
        /// <param name="id">The Id to check</param>
        /// <returns>Teh result</returns>
        public static bool ContainsID(ulong id)
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
                if (id < MAXSIZE_UNIVERSITY)
                    id++;
                else
                    throw new OverflowException(ERROR_ID_OVERFLOW);
            }

            return id;
        }

        private static uint GenerateNewID(ushort universityID)
        {
            uint id = universityID * MULTIPLYER_UNIVERSITY + 1;
            while (ContainsModule(id))
            {
                if (id < MAXSIZE_MODULE)
                    id++;
                else
                    throw new OverflowException(ERROR_ID_OVERFLOW);
            }

            return id;
        }

        private static ulong GenerateNewID(uint moduleID)
        {
            ulong id = moduleID * MULTIPLYER_MODULE + 1;
            while (ContainsEvent(id))
            {
                if (id < MAXSIZE_EVENT)
                    id++;
                else
                    throw new OverflowException(ERROR_ID_OVERFLOW);
            }

            return id;
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