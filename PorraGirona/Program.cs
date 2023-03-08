using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PorraGirona
{
    internal static class Program
    {
        // possible fix: update-package -reinstall (Tools, nug packet console)
        /// <summary>
        /// PM> Uninstall-Package MySql.Data -RemoveDependencies
        /// PM> Install-Package MySql.Data -Version 8.0.17
        /// Punto de entrada principal para la aplicación.
        /// </summary>
                [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PresentationLayer.FormLogin());
            //Application.Run(new Principal());
        }


    }
}
