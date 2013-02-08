
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
    }
}
