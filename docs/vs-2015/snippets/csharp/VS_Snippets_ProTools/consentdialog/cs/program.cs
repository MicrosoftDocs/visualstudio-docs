using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ConsentDialog
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        //<snippet5>
        static int Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 f = new Form1();
            Application.Run(f);
            if (!f.accepted)
                return -1;
            else
                return 0;
        }
        //</snippet5>
    }
}
