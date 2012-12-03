using System;
using System.Windows.Forms;
using Studyplaner.GUI.Forms;
using Studyplaner.Manager;
using System.Runtime.InteropServices;

namespace Studyplaner
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

          
            //UniversityManager mgr = new UniversityManager("bla");

            //Console.Out.WriteLine("1:    " + mgr.GenerateNextID());
            //Console.Out.WriteLine("2:    " + mgr.GenerateNextID());

            //Console.Out.WriteLine("Add some values...");
            //mgr.foo(new int[] { 3, 4, 5, 6, 7, -1, 9, -1, 11, 12, 13, 14, -1, 16 });

            //Console.Out.WriteLine("8?:    " + mgr.GenerateNextID());
            //Console.Out.WriteLine("10?:    " + mgr.GenerateNextID());
            //Console.Out.WriteLine("15?:    " + mgr.GenerateNextID());
            //Console.ReadLine();
        }
    }
}
