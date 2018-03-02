using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _06_Heizanlage
{
    static class Program
    {
        public static int houses;
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartScreen());
        }
    }
}
