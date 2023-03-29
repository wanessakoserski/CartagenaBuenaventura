using CartagenaBuenaventura.Classes;
using CartagenaServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CartagenaBuenaventura
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string a = Jogo.VerificarVez(1);
            Console.WriteLine(a);
            Application.Run(Panel.getInstance());
        }
    }
}
