using FERNANDES_ROCCIA_TAPIA.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FERNANDES_ROCCIA_TAPIA
{
    internal static class Program
    {
        
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());



        }
    }
}
