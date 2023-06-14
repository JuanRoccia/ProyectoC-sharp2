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
    /// En este formulario, se gestionara todo lo relacionado a la clase Tesla.
    /// Se podran dar de alta y eliminar objetos Tesla, en la lista recibida
    /// del formulario principal que es donde se van a ir almacenando 
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
        }

        #endregion
    }
}
