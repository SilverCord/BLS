using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LibraryDesign_frontEndUI
{
    static class Program
    {
        internal static LibMain MainObj = null;
       
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainObj = new LibMain();
            Application.Run(MainObj);
            //Application.Run(new frmLibMainMdi());
            
        }
    }
}
