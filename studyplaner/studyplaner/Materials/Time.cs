using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Studyplaner.Materials
{
    public struct Time
    {
        private const Regex TIMEFULLREGEX = new Regex("[\\d]{1,2}?(:[\\d]{2})?");
        private const Regex TIMEHOURSREGEX = new Regex("[\\d]{1,2}");
        private const Regex TIMEMINUTESREGEX = new Regex(":[\\d]{2}");

        public byte Hours { get; private set; }
        public byte Minutes { get; private set; }

        /// <summary>
        /// New Time.
        /// </summary>
        /// <param name="hours">The hours</param>
        /// <param name="minutes">The minutes</param>
        public Time(byte hours, byte minutes) : this()
        {
            Hours = hours;
            Minutes = minutes;
        }

        /// <summary>
        /// Tries to parse the string <code>str</code> into
        /// a Time.
        /// 
        /// Time-string syntax: either [h]h:mm oder [h]h.
        /// </summary>
        /// <param name="str">The string to parse</param>
        /// <returns>The aquivalent Time</returns>
        public static Time ValueOf(string str)
        {
            if (!TIMEFULLREGEX.IsMatch(str, 0))
                throw new ArgumentException("str", "Invalid Time-syntax!");

            //TODO continue

            return new Time(0, 0);
        }

        public override string ToString()
        {
            return String.Format("{0:00}:{1:00}", Hours, Minutes);
        }
    }
}
