using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Studyplaner
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// Simplifies EventRaising
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="eventHandler">The EventHandler of the event to raise</param>
        /// <param name="sender">Sender of the event</param>
        /// <param name="e">EventArgs of the Event</param>
        public static void Raise<T>(this EventHandler<T> eventHandler, Object sender, T e) where T : EventArgs
        {
            if (eventHandler != null)
            {
                eventHandler(sender, e);
            }
        }

        /// <summary>
        /// Returns the Week of Year of a date.
        /// Calculated through the calendar of the current CultureInfo.
        /// </summary>
        /// <param name="date">The date itself</param>
        /// <returns>The WeekOfYear</returns>
        public static int WeekOfYear(this DateTime date)
        {
            return CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }
    }
}
