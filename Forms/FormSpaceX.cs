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
                !string.IsNullOrEmpty(hsActual.Text) && hsActual.Text.All(Char.IsDigit)
                && (hsActual.Text.Length > 0) && (hsActual.Text.Length < 8)
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
        /// Esta funcion tendra un condicional para evaluar que modelo de Tesla se eligió
        /// para asi asignar la autonomia(int), asientos(int), service(int) y asi no 
        /// se creen modelos con datos erroneos. Tambien obtendra los datos
        /// de los textbox y los combobox.
        /// "Modelo X: 560, 7, 1000"
        /// "Modelo S: 650, 5, 2000"
        /// "Cybertruck: 800, 6, 3000"
        /// </summary>
        /// 
        private void guardarSpaceX()
        {
            try
            {
                string modelo = modelos.SelectedItem.ToString();
                int autonomia;
                int service;
                //condicion para asignar asientos y autonomia del Tesla segun modelo
                if (modelo == "Falcon 9")
                {
                    autonomia = 560;
                    service = 1000;
                }
                else if (modelo == "Starship")
                {
                    autonomia = 650;
                    service = 2000;
                }

                int anio = Convert.ToInt32(anios.SelectedItem);
                int horasVuelo = Convert.ToInt32(hsActual.Text);
                string color = colores.SelectedItem.ToString();
                string nombre = duenio.Text.Trim().ToUpper();

                SpaceX spaceX = new SpaceX(modelo, anio, horasVuelo, horasService, color, duenio, autonomia, service);
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
                hsActual.Clear();
                colores.SelectedIndex = -1;
                duenio.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al crear un tesla" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        #endregion
    }
}
