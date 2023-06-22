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

namespace FERNANDES_ROCCIA_TAPIA
{

    public partial class FormSpaceX : Form
    {
        #region Cargar un SpaceX
        List<SpaceX> lista;
        string[] modelos_disponibles = { "Falcon 9", "Starship" };
        int[] anios_disponibles = { 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020, 2021, 2022, 2023 };
        string[] colores_disponibles = { "Black", "Blue", "Gray", "Green", "Red", "White" };
        public FormSpaceX(List<SpaceX> listaSpaceX)
        {
            InitializeComponent();
            lista = listaSpaceX;
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

        #region Boton crear SpaceX y funcion guardarSpaceX
        /// <summary>
        /// El boton crear SpaceX sera el encargado de hacer todas las validaciones
        /// de campos, sino no se podra llamar al metodo guardarSpaceX() que es quien 
        /// permite la instanciacion de la clase SpaceX, y agrega el objeto a la lista principal
        /// de SpaceX's. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if ((modelos.SelectedIndex >= 0) && (anios.SelectedIndex >= 0) &&
                !string.IsNullOrEmpty(hsVueloActual.Text) && hsVueloActual.Text.All(Char.IsDigit)
                && (hsVueloActual.Text.Length > 0) && (hsVueloActual.Text.Length < 8)
                && (colores.SelectedIndex >= 0) && (duenio.Text.Trim() != string.Empty)
                && (duenio.Text.All(Char.IsLetter)
                || duenio.Text.Any(Char.IsWhiteSpace)) && (duenio.Text.Trim().ToString().Length > 4))
            {
                guardarSpaceX();
                errorProvider1.SetError(grupoDatos, "");
            }
            else
            {
                errorProvider1.SetError(grupoDatos, "* Para guardar un SpaceX todos los campos deben estar completos y deben ser del tipo correcto.\n" +
                                                "! Hs. Actuales: sólo puede contener numeros positivos entre 0 y 10 millones.\n" +
                                                "! Dueño: sólo puede contener letras y espacios, debe contener como mínimo 5 caracteres.");
                grupoDatos.Focus();
            }
        }
        /// <summary>
        /// Esta funcion tendra un condicional para evaluar que modelo de SpaceX se eligió
        /// para asi asignar las horas de autonomia(int) y service(int) y asi no 
        /// se creen modelos con datos erroneos. Tambien obtendra los datos
        /// de los textbox y los combobox.
        /// </summary>
        /// 
        private void guardarSpaceX()
        {
            try
            {
                string modelo = modelos.SelectedItem.ToString();
                int autonomia;
                int service;
                //condicion para asignar service y autonomia del SpaceX segun modelo
                if (modelo == "Falcon 9")
                {
                    autonomia = 200;
                    service = 400;
                }
                else
                {
                    // Starship
                    autonomia = 500;
                    service = 1000;
                }

                int anio = Convert.ToInt32(anios.SelectedItem);
                int HsVueloActual = Convert.ToInt32(hsVueloActual.Text);
                string color = colores.SelectedItem.ToString();
                string nombre = duenio.Text.Trim().ToUpper();
                
                SpaceX spaceX = new SpaceX(modelo, anio, HsVueloActual, color, nombre, autonomia, service);
                lista.Add(spaceX);
                // public FormSpaceX(List<SpaceX> listaSpaceX)

                string mensaje = $"Creó un SpaceX correctamente y se agregó a la lista con el ID: {spaceX.Id}.";
                MessageBoxButtons botones = MessageBoxButtons.OK;
                MessageBox.Show(mensaje, "Genial", botones);
                //Reset clear

                dgv_tesla.DataSource = null;
                dgv_tesla.DataSource = lista;

                modelos.SelectedIndex = -1;
                anios.SelectedIndex = -1;
                hsVueloActual.Clear();
                colores.SelectedIndex = -1;
                duenio.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al crear un tesla" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        #endregion

        #region Boton eliminar y funcionalidad
        /// <summary>
        /// Funcion para obtener informacion y poder eliminar elementos de la lista
        /// mostrada en el datagridview, para eso se usa la funcion 
        /// CellClick del datagrid para obtener el indice
        /// del elemento que queremos eliminar, y eliminamos por indice = id.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private int indiceFila;
        private int idc;
        private void dgv_tesla_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            indiceFila = e.RowIndex;
            labelEscaneo.Visible = false;
        }
        // Funcion para el boton eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (indiceFila != -1)
                {
                    idc = (int)dgv_tesla.Rows[indiceFila].Cells[0].Value;
                    DialogResult dialogResult = MessageBox.Show($"Esta seguro que desea eliminar el SpaceX ID: {idc} ?"
                                            , "Eliminar SpaceX", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        lista.RemoveAt(indiceFila);
                        dgv_tesla.DataSource = null;
                        dgv_tesla.DataSource = lista;
                        indiceFila = -1;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al eliminar un tesla" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        #endregion

        #region Boton Escanear
        /// <summary>
        /// Este boton va a realizar el escaneo del SpaceX que se seleccione
        /// del DataGridView, haciendo referencia al objeto que se encuentra 
        /// guardado en la lista del prgorama principal.
        /// Para evitar errores de ejecucion se valida que la lista no este vacía,
        /// y en el DataGridView unicamente se permite la seleccion de filas.
        /// Si el DTG esta vacío se mostrará un error al costado derecho 
        /// del botón.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void btnEscanear_Click(object sender, EventArgs e)
        {
            try
            {
                if (lista.Count > 0)
                {
                    SpaceX teslac = (SpaceX)dgv_tesla.CurrentRow.DataBoundItem;
                    labelEscaneo.Text = teslac.Escaneo();
                    labelEscaneo.Visible = true;
                }
                else
                {
                    errorProvider1.SetError(btnEscanear, "Error la lista esta vacía.");
                    btnEscanear.Focus();
                }
            }
            catch (Exception ex)
            {
                // Manejo de la excepción
                MessageBox.Show("Se produjo un error al escanear un tesla. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion
    }
}
