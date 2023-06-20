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
        #region Inicio y carga del formulario
        List<SpaceX> lista;
        string[] modelos_disponibles = { "Falcon 9", "Starship" };
        int[] anios_disponibles = { 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020, 2021, 2022, 2023 };
        string[] colores_disponibles = { "Black", "Blue", "Gray", "Green", "Red", "White" };
        public FormSpaceX(List<SpaceX> listaSpaceX)
        {
            InitializeComponent();
            lista = listaSpaceX;
        }
        #endregion
    }
}
