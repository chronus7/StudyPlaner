using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Studyplaner
{
    public static class ExtensionMethods
    {
        public static void Raise<T>(this EventHandler<T> eventHandler, Object sender, T e) where T : EventArgs
        {
            if (eventHandler != null)
            {
                eventHandler(sender, e);
            }
        }
    }
}
