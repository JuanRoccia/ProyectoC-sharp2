﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FERNANDES_ROCCIA_TAPIA.Entidades;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace FERNANDES_ROCCIA_TAPIA
{
    /// <summary>
    /// El programa principal va a constar de 2 vistas generales. 
    /// Una para la empresa Tesla y otra para la empresa SpaceX.
    /// Se realizaran todas las funcionalidades requeridas en el proyecto más
    /// funciones adicionales que creímos convenientes para que la interfaz
    /// sea amigable con el usuario.
    /// Se crearon los botones de minimizar, maximizar, y cerrar el programa
    /// al estilo windows, pero se creó una interfaz moderna que consta
    /// de un formulario principal, y subformularios hijos que se mostrarán
    /// en un panel secundario el cual se denomina "panelContenedor".
    /// Se tomo la decisión de implementar este modelo, ya que es fácil de escalar.
    /// Se tuvo la idea que este código se puede reutilizar para 
    /// diferentes tipos de vehiculos y/o marcas.
    /// En este mismo formulario principal, se podrian agregar mas vistas, funcionalidades y botones.
    /// El programa inicialmente tendra dos listas una correspondiente a cada empresa,
    /// estas listas simulan los datos que estarian guardados en de una base de datos,
    /// las listas seran enviadas como argumentos del constructor de cada formulario hijo.
    /// Cada formulario hijo trabajará y manipulará estas listas
    /// dando de alta o eliminando algun elemento de la misma.
    ///  
    /// La definción e instancia de clases, y agregar objetos a lista
    /// cuando se inicial el formulario es para pruebas de testeo,
    /// pero no es la idea que se puedan realizar modificaciones de esta manera,
    /// sino que toda alta, baja o modificación se realice a traves de la interfaz gráfica.
    /// </summary>
    public partial class Form1 : Form
    {
        #region Inicio del formulario principal
        public List<Tesla> listaTesla;
        Tesla tesla1 = new Tesla("Model S", 2015, 2300,  "Azul", "ELON MUSK", 650, 5, 2000);
        Tesla tesla2 = new Tesla("Model X", 2015, 23000,  "Rojo", "ELON MUSK", 560, 7, 1000);
        Tesla tesla3 = new Tesla("Model X", 2015, 250500,  "Negro", "ELON MUSK", 560, 7, 1000);
        Tesla tesla4 = new Tesla("Cybertruck", 2015, 90000,  "Bordo", "ELON MUSK", 800, 6, 3000);
        public List<SpaceX> listaSpaceX;
        SpaceX space1 = new SpaceX("Falcon 9", 2015, 2300, "Azul", "NASA", 200, 400);
        SpaceX space2 = new SpaceX("Starship", 2015, 23000, "Rojo", "PLANET LABS", 500, 1000);
        SpaceX space3 = new SpaceX("Falcon 9", 2015, 250500, "Negro", "DDEU", 200, 400);
        SpaceX space4 = new SpaceX("Starship", 2015, 90000, "Bordo", "IRIDIUM COM.", 500, 1000);
        /// <summary>
        /// Constructor del formulario principal, se inicia la lista cuando se inicia el programa
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            listaTesla = new List<Tesla>();
            listaTesla.Add(tesla1);
            listaTesla.Add(tesla2);
            listaTesla.Add(tesla3);
            listaTesla.Add(tesla4);
            listaSpaceX = new List<SpaceX>();
            listaSpaceX.Add(space1);
            listaSpaceX.Add(space2);
            listaSpaceX.Add(space3);
            listaSpaceX.Add(space4);


            // Establecer el tamaño del formulario
            this.Size = new Size(1400, 650);

            // O maximizar el formulario
            //this.WindowState = FormWindowState.Maximized;
        }
        #endregion

        #region Control botones salir, minimizar , maximizar    
        /// <summary>
        /// Boton cerrar, me cierra este formulario principal. 
        /// Utilizando la funcion Close() sobre este formulario(FORMULARIO PRINCIPAL DEL PROGRAMA)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Boton maximizar, con lógica para que se vea
        /// unicamente cuando la ventana este en modo normal,
        /// de otro modo este boton estará invisible
        /// y  se verá el boton de Restaurar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        /// <summary>
        /// Boton restaurar, con la lógica inversa del botón maximizar,
        /// el boton estará disponible solo si la ventana esta maximizada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
        }

        /// <summary>
        /// Boton minimizar, me cambia el estado del formulario principal a minimizado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        /// <summary>
        /// Se importan las DLL para poder hacer el diseño responsivo, y permitir el desplazamiento
        /// de la ventana, se utiliza para mejorar la experiencia con el usuario
        /// </summary>
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Control de botones principales, y creacion de formularios hijos
        /// <summary>
        /// Abre un formulario hijo dentro del panelContenedor que esta dentro del formulario principal.
        /// Con el if nos aseguramos de que no haya ningún control previamente agregado 
        /// en el panelContenedor antes de agregar un nuevo control, 
        /// y si hay alguno, lo elimina. Esto es útil si se desea reemplazar 
        /// o actualizar el contenido del contenedor con un nuevo control.
        /// </summary>
        /// <param name="formHijo">El formulario hijo que se va a abrir.</param>
        public void AbrirFormHijo(object formHijo)
        {
            // Verifica si hay controles en el panelContenedor y elimina el primero, si existe.
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            // Crea una instancia del formulario hijo y se establecen propiedades importantes.
            Form fH = formHijo as Form;
            fH.TopLevel = false;
            fH.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fH);
            this.panelContenedor.Tag = fH;
            fH.Show();
        }

        /// <summary>
        /// Esta función me va a crear y abrir un formulario de la clase
        /// FormTesla(), que debe recibir una lista como parametro
        /// y se mostrará en el panelContenedor.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTesla_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FormTesla(listaTesla));
        }

        /// <summary>
        /// Esta funcion me va a crear y abrir formulario de la clase
        /// FormSpaceX(), que debe recibir una lista como parametro
        /// se mostrara el formulario en el panelContenedor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSpaceX_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FormSpaceX(listaSpaceX));
        }

        #endregion
    }
}