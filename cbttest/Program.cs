using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace cbttest
{
  //  C:\Users\Onalz_joseph\Documents\Visual Studio 2010\Projects\cbttest\cbttest\Program.cs
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
