
namespace Studyplaner.UniversityStuff
{
    /// <summary>
    /// Short class to summarize some
    /// UniversityManager-related functions
    /// so the Universitymanager does not
    /// get overloaded.
    /// </summary>
    class UniversityFunctions
    {
        /// <summary>
        /// Returns the parental UniversityID of the given
        /// UniversityModule.
        /// </summary>
        /// <param name="moduleid">The UniversityModule's ID to get the related UniversityID</param>
        /// <returns>The University's ID</returns>
        public static ushort GetUniID(uint moduleid)
        {
            return (ushort)(moduleid / UniversityManager.MULTIPLYER_UNIVERSITY);
        }

        /// <summary>
        /// Returns the parental UniversityID of the given
        /// UniversityEvent.
        /// </summary>
        /// <param name="eventid">The UniversityEvent's ID to get the related UniversityID</param>
        /// <returns>The University's ID</returns>
        public static ushort GetUniID(ulong eventid)
        {
            return GetUniID(GetModuleID(eventid));
        }

        /// <summary>
        /// Returns the parental UniversityModuleID of the
        /// given UniversityEvent.
        /// </summary>
        /// <param name="eventid">The UniversityEvent's ID to get the related UniversityModuleID</param>
        /// <returns>The UniversityModule's ID</returns>
        public static uint GetModuleID(ulong eventid)
        {
            return (uint)(eventid / (UniversityManager.MULTIPLYER_MODULE
                * UniversityManager.MULTIPLYER_UNIVERSITY)); // TODO ??
        }

        /// <summary>
        /// Returns wether the given University's ID is valid or not.
        /// </summary>
        /// <param name="uniID">The University's ID to be checked.</param>
        /// <returns>True | False</returns>
        public static bool IsValidID(ushort uniID)
        {
            return (uniID > 0) &&
                (uniID < UniversityManager.MAXSIZE_UNIVERSITY);
        }

        /// <summary>
        /// Returns wether the given UniversityModule's ID
        /// is valid or not.
        /// </summary>
        /// <param name="moduleID">The UniversityModule's ID
        /// to be checked.</param>
        /// <returns>True | False</returns>
        public static bool IsValidID(uint moduleID)
        {
            ushort uni = GetUniID(moduleID);
            uint module = moduleID % UniversityManager.MULTIPLYER_UNIVERSITY;

            return (IsValidID(uni) &&
                (module > 0 &&
                module < UniversityManager.MULTIPLYER_UNIVERSITY)); // isn't this given by modulo?
        }

        /// <summary>
        /// Returns wether the given UniversityEvent's ID
        /// is valid or not
        /// </summary>
        /// <param name="eventID">The UniversityEvent's ID
        /// to be checked</param>
        /// <returns>True | False</returns>
        public static bool IsValidID(ulong eventID)
        {
            ushort uni = GetUniID(eventID);
            uint module = GetModuleID(eventID);
            ulong ev = eventID % UniversityManager.MULTIPLYER_MODULE;

            return (IsValidID(uni) && // should be verified by IsValidID(module)...
                IsValidID(module) &&
                (ev > 0) &&
                (ev < UniversityManager.MULTIPLYER_MODULE));
        }
    }
}
