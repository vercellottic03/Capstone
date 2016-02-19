using System;
using System.Windows.Forms;

namespace The_Gaming_Library
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        [STAThread]
        static void Main()
        {
            //This is where the application begins, by calling the login window, so when that window is closed, the whole app goes 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Begin the process
            Application.Run(new LOGINWINDOW());
        }
    }
}
