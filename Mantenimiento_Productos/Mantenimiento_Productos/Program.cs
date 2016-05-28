using Mantenimiento_Productos.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mantenimiento_Productos
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
            //Creo el splash 
            UISplash vloSplash = new UISplash();
            if (vloSplash.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new VerFruta_Express());
            }
            
        }
    }
}
