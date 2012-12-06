using Studyplaner.Enums;
using System;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace Studyplaner.Values
{
    public struct Time : IXmlSerializable
    {
        //private static readonly Regex TIMEFULLREGEX = new Regex("^[0-2]?[\\d](:[0-5][\\d])?$");
        //private static readonly Regex TIMEHOURSREGEX = new Regex("[\\d]{1,2}");
        //private static readonly Regex TIMEMINUTESREGEX = new Regex(":[\\d]{2}");

        /// <summary>
        /// The hours of this Time.
        /// </summary>
        public byte Hours { get; private set; }
        /// <summary>
        /// The minutes of this Time.
        /// </summary>
        public byte Minutes { get; private set; }
        /// <summary>
        /// The WeekInterval of this Time.
        /// </summary>
        public WeekInterval WeekInterval { get; private set; }
        /// <summary>
        /// The Date of this Time.
        /// Returns NOT always the same Date but the next upcoming DateTime of the Time
        /// or simply the (possibly) passed DateTime if the WeekIntervall is FixedDate
        /// </summary>
        public DateTime Date 
        {
            get
            {
                if (WeekInterval == Enums.WeekInterval.FixedDate)
                    return _date;
                else
                    return GetNextValidDate();
            }
            private set
            {
                _date = value;
            }
        }
        private DateTime _date;

        // gets the next (upcoming) DateTime
        private DateTime GetNextValidDate()     // TODO: needs changes if we decide to use FirstDate and LastDate
        {
            DateTime newDate = new DateTime(_date.Year, _date.Month, _date.Day, _date.Hour, _date.Minute, _date.Second);
            switch (WeekInterval)
            {
                case WeekInterval.EveryWeek:
                    if (newDate.Date < DateTime.Now)
                        newDate = AddUntilValid(newDate, 7);
                    break;
                case WeekInterval.EveryTwoWeeks:
                    if (newDate.Date < DateTime.Now)
                        newDate = AddUntilValid(newDate, 14);
                    break;
                case WeekInterval.FixedDate:    // code doesnt get here.. might remove this case
                    break;
                default:
                    break;
            }
            return newDate;
        }

        // helper method for AddUntilValid
        private DateTime AddUntilValid(DateTime original, int days)
        {
            do
            {
                original.AddDays(days);
            } while (original.Date < DateTime.Now);

            return original;
        }

        /// <summary>
        /// New Time.
        /// </summary>
        /// <param name="hours">The hours</param>
        /// <param name="minutes">The minutes</param>
        /// <param name="weekInterval">The WeekInterval of this event</param>
        public Time(byte hours, byte minutes, DateTime date, WeekInterval weekInterval) : this()
        {
            Hours = hours;
            Minutes = minutes;
            Date = date;
            WeekInterval = weekInterval;
        }

        /// <summary>
        /// New Time. FixedDate
        /// </summary>
        /// <param name="hours">The hours</param>
        /// <param name="minutes">The minutes</param>
        /// <param name="date">The exact date of this event.
        /// Just put the date. The time will be overridden</param>
        public Time(byte hours, byte minutes, DateTime date) : this(hours, minutes, date, WeekInterval.FixedDate)
        {
        }

        /// <summary>
        /// Tries to parse the string <code>str</code> into
        /// a Time. It will be set to <seealso cref="WeekInteval.EveryWeek"/>.
        /// 
        /// Time-string syntax: either [h]h:mm oder [h]h.
        /// </summary>
        /// <param name="time">The string to parse</param>
        /// <returns>The aequivalent Time</returns>
        //public static Time ValueOf(string time)
        //{
        //    if (!TIMEFULLREGEX.IsMatch(time, 0))
        //        throw new ArgumentException("time", "Invalid Time-syntax!");

        //    Match mhours = TIMEHOURSREGEX.Match(time);
        //    String val = mhours.Groups[0].Value;
        //    byte hours = Byte.Parse(val);

        //    if (TIMEMINUTESREGEX.IsMatch(time))
        //    {
        //        Match mMinutes = TIMEMINUTESREGEX.Match(time);
        //        String valh = mMinutes.Groups[0].Value;
        //        valh = valh.Substring(1);
        //        byte minutes = Byte.Parse(valh);
        //        return new Time(hours, minutes, WeekInterval.EveryWeek);
        //    }

        //    return new Time(hours, 0, WeekInterval.EveryWeek);
        //}

        public override string ToString()
        {
            return String.Format("{0:00}:{1:00}", Hours, Minutes);
        }

        public System.Xml.Schema.XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(System.Xml.XmlReader reader)
        {
            reader.MoveToContent();
            reader.ReadStartElement();
            WeekInterval = (WeekInterval)Enum.Parse(typeof(WeekInterval),
                reader.ReadElementString("interval"));
            Hours = byte.Parse(reader.ReadElementString("hours"));
            Minutes = byte.Parse(reader.ReadElementString("minutes"));
            Date = DateTime.Parse(reader.ReadElementString("date"));
            reader.ReadEndElement();
        }

        public void WriteXml(System.Xml.XmlWriter writer)
        {
            writer.WriteElementString("interval", WeekInterval.ToString());
            writer.WriteElementString("hours", Hours.ToString());
            writer.WriteElementString("minutes", Minutes.ToString());
            writer.WriteElementString("date", Date.ToShortDateString());
        }
    }
}