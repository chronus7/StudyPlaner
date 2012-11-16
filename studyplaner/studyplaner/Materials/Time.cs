using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Studyplaner.Materials
{
    public struct Time
    {
        private static readonly Regex TIMEFULLREGEX = new Regex("[\\d]{1,2}?(:[\\d]{2})?");
        private static readonly Regex TIMEHOURSREGEX = new Regex("[\\d]{1,2}");
        private static readonly Regex TIMEMINUTESREGEX = new Regex(":[\\d]{2}");

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
        /// <returns>The aequivalent Time</returns>
        public static Time ValueOf(string str)
        {
            if (!TIMEFULLREGEX.IsMatch(str, 0))
                throw new ArgumentException("str", "Invalid Time-syntax!");

            //TODO continue
            Match mhours = TIMEHOURSREGEX.Match(str);
            String val = mhours.Groups[0].Value;
            byte hours = Byte.Parse(val);

            if (TIMEMINUTESREGEX.IsMatch(str))
            {
                Match mMinutes = TIMEMINUTESREGEX.Match(str);
                String valh = mMinutes.Groups[0].Value;
                valh = valh.Substring(1);
                byte minutes = Byte.Parse(valh);
                return new Time(hours, minutes);
            }

            return new Time(hours, 0);
        }

        public override string ToString()
        {
            return String.Format("{0:00}:{1:00}", Hours, Minutes);
        }
    }
}
