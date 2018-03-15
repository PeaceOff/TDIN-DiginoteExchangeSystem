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
            Form1 f = new Form1();
            Application.Run(f);

            f.setLabel("Boas");

            // RemotingConfiguration.Configure("Client.exe.config", false);

            IDiginoteSystem system = (IDiginoteSystem) RemotingServices.Connect(typeof(IDiginoteSystem),
                "tpc://192.168.137.223:999/server/diginoteEndpoint");
            
            f.setLabel(system.ReturnHello());


        }
    }
}
