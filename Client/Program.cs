using System;
using System.Windows.Forms;
using System.Runtime.Remoting;
using TDIN_Proj1;

namespace Client
{
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
            ClientForm f = new ClientForm();
            Application.Run(f);
        }
    }
}
