using FERNANDES_ROCCIA_TAPIA.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FERNANDES_ROCCIA_TAPIA.Entidades;

namespace FERNANDES_ROCCIA_TAPIA
{

    /// <summary>
    /// 
    /// En este formulario, se gestionara todo lo relacionado a la clase Tesla.
    /// Se podran dar de alta y eliminar objetos Tesla, en la lista recibida
    /// del formulario principal que es donde se van a ir almacenando los teslas.
    /// Tambien contendra toda la funcionalidad, y toda la logica necesaria
    /// para que la instancia de un nuevo objeto Tesla sea correcta.
    /// Se tendran en cuenta los datos ingresados/seleccionados
    /// por el usuario y dependiendo de ellos, se haran calculos para 
    /// implentar lo solicitado en el proyecto.
    /// Se tendra la vista de la lista actual de teslas en un DataGridView
    /// y se podran dar de alta, o eliminar teslas de esta lista.
    /// Se usara una funcion para asignar todos los datos y dar de alta un tesla,
    /// se implementera la logica necesaria para que cada modelo de Tesla se cree
    /// con las propiedades particulares del modelo seleccionado en un comboBox por el usuario.
    /// Esto evita que se creen modelos que no existen, o designados por un usuario normal.
    /// Las opciones de modelos, anios y colores solo podran modificarlo los desarrolladores,
    /// a traves de las listas estaticas correspondientes, como asi tambien la asignacion
    /// de las propiedades particulares, asientos, autonomia y service.
    /// 
    /// </summary>
    public partial class FormTesla : Form
    {
        #region Cargar dar de alta un Tesla
        List<Tesla> lista;
        string[] modelos_disponibles = { "Model X", "Model S", "Cybertruck" };
        int[] anios_disponibles = { 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020, 2021, 2022, 2023 };
        string[] colores_disponibles = { "Black", "Blue", "Gray", "Green", "Red", "White" };
        public FormTesla(List<Tesla> listaTeslas)
        {
            InitializeComponent();
            lista = listaTeslas;
            dgv_tesla.DataSource = lista;
            popularModelos();
            popularAnios();
            popularColores();
        }

        /// <summary>
        /// Agrega los modelos disponibles al ComboBox "modelos".
        /// </summary>
        private void popularModelos()
        {
            foreach (string modelo in modelos_disponibles)
            {
                modelos.Items.Add(modelo);
            }
        }
        /// <summary>
        /// Agrega los años disponibles al ComboBox "anios".
        /// </summary>
        private void popularAnios()
        {
            foreach (int anio in anios_disponibles)
            {
                anios.Items.Add(anio);
            }
        }

        /// <summary>
        /// Agrega los colores disponibles al ComboBox "colores".
        /// </summary>
        private void popularColores()
        {
            foreach (string color in colores_disponibles)
            {
                colores.Items.Add(color);
            }
        }
        #endregion

        #region Boton crear tesla y funcion guardarTesla
        /// <summary>
        /// El boton crear tesla sera el encargado de hacer todas las validaciones
        /// de campos, sino no se podra llamar al metodo guardarTesla() que es quien 
        /// permite la instanciacion de la clase Tesla, y agrega el objeto a la lista principal de Teslas.
        /// Estos valores se asignaran automaticamente dependiendo del modelo seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if ((modelos.SelectedIndex >= 0) && (anios.SelectedIndex >= 0) &&
                !string.IsNullOrEmpty(kmActuales.Text) && kmActuales.Text.All(Char.IsDigit)
                && (kmActuales.Text.Length > 0) && (kmActuales.Text.Length < 8)
                && (colores.SelectedIndex >= 0) && (duenio.Text.Trim() != string.Empty)
                && (duenio.Text.All(Char.IsLetter)
                || duenio.Text.Any(Char.IsWhiteSpace)) && (duenio.Text.Trim().ToString().Length > 4))
            {
                guardarTesla();

                string mensaje = $"Creó un Tesla correctamente y se agregó a la lista con el ID: {lista.Count.ToString()}";
                MessageBoxButtons botones = MessageBoxButtons.OK;
                MessageBox.Show(mensaje, "Genial", botones);
                errorProvider1.SetError(grupoDatos, "");

            }
            else
            {
                errorProvider1.SetError(grupoDatos, "* Para guardar un tesla todos los campos deben estar completos y deben ser del tipo correcto.\n" +
                                                "! Kms. Actuales: sólo puede contener numeros positivos entre 0 y 10 millones.\n" +
                                                "! Dueño: sólo puede contener letras y espacios, debe contener como mínimo 5 caracteres.");
                grupoDatos.Focus();
            }
        }

        /// <summary>
        /// Esta funcion tendra un condicional para evaluar que modelo de Tesla se eligió
        /// para asi asignar la autonomia(int), asientos(int), service(int) y asi no 
        /// se creen modelos con datos erroneos. Tambien obtendra los datos
        /// de los textbox y los combobox.
        /// "Modelo X: 560, 7, 1000"
        /// "Modelo S: 650, 5, 2000"
        /// "Cybertruck: 800, 6, 3000"
        /// </summary>
        private void guardarTesla()
        {

            string modelo = modelos.SelectedItem.ToString();
            int asientos;
            int autonomia;
            int service;
            //condicion para asignar asientos y autonomia del Tesla segun modelo
            if (modelo == "Model X")
            {
                autonomia = 560;
                asientos = 7;
                service = 1000;
            }
            else if (modelo == "Model S")
            {
                autonomia = 650;
                asientos = 5;
                service = 2000;
            }
            else
            {
                autonomia = 800;
                asientos = 6;
                service = 3000;
            }

            int anio = Convert.ToInt32(anios.SelectedItem);
            int kmActual = Convert.ToInt32(kmActuales.Text);
            string color = colores.SelectedItem.ToString();
            string nombre = duenio.Text.Trim().ToUpper();

            Tesla tesla = new Tesla(modelo, anio, kmActual, color, nombre, autonomia, asientos, service);
            lista.Add(tesla);

            //Reset clear

            dgv_tesla.DataSource = null;
            dgv_tesla.DataSource = lista;

            modelos.SelectedIndex = -1;
            anios.SelectedIndex = -1;
            kmActuales.Clear();
            colores.SelectedIndex = -1;
            duenio.Clear();
        }
        #endregion

        #region Boton Eliminar y funcionalidad

        /// <summary>
        /// Funcion para obtener informacion y poder eliminar elementos de la lista
        /// mostrada en el datagridview, para eso se usa la funcion 
        /// CellClick del datagrid para obtener el indice
        /// del elemento que queremos eliminar, y eliminamos por indice = id.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private int indiceFila;
        private int idc;

        private void dgv_tesla_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            indiceFila = e.RowIndex;
            labelEscaneo.Visible = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (indiceFila != -1)
            {
                idc = (int)dgv_tesla.Rows[indiceFila].Cells[0].Value;
                DialogResult dialogResult = MessageBox.Show($"Esta seguro que desea eliminar el tesla ID: {idc} ?"
                                        , "Eliminar tesla", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    lista.RemoveAt(indiceFila);
                    dgv_tesla.DataSource = null;
                    dgv_tesla.DataSource = lista;
                    indiceFila = -1;
                }
            }
        }
        #endregion

        #region Boton Escanear
        private void btnEscanear_Click(object sender, EventArgs e)
        {
            Tesla teslac = (Tesla)dgv_tesla.CurrentRow.DataBoundItem;

            labelEscaneo.Text = teslac.Escaneo();
            labelEscaneo.Visible = true;

        }
        #endregion
    }
}

