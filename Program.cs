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
        /// 
        /// Esta aplicación es una herramienta de gestión de tareas desarrollada en C# con Windows Forms.
        /// Permite a los usuarios crear, editar y eliminar tareas. La lógica de la aplicación se basa en la interacción
        /// entre los formularios (interfaz gráfica de usuario) y las clases (lógica de la aplicación).
        /// 
        /// Para una explicación más detallada de la lógica de la aplicación, las decisiones de diseño tomadas,
        /// y cómo interactúa el código con la interfaz gráfica de usuario, consulte el archivo README en el repositorio.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
