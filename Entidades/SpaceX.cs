using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERNANDES_ROCCIA_TAPIA.Entidades
{
    /// <summary>
    /// La clase SpaceX hereda de la clase abstracta Vehiculo,
    /// en la interfaz se podran seleccionar e ingrasar datos,
    /// que seran verificados con condiciones logicas para
    /// la correcta instanciacion de la clase SpaceX acorde
    /// a su metodo constructor y al modelo seleccionado por el usuario
    /// solo se podran crear SpaceX's modelo: (Falcon 9,  Starship).
    /// Las propiedades caracteristicas de cada modelo se asignaran
    /// automaticamente y sera transparente para el usuario.
    /// Por ejemplo si se elige en el comboBox "Falcon 9" se asignara
    /// como autonomia:200 HS y como service: 400HS
    /// </summary>
    public class SpaceX : Vehiculo
    {

        #region Propiedades
        private static int contadorId = 0;
        private int id;
        private int horasVuelo;
        private int horasService;
        private const int sistemaPropulsion = 1000;
        private const int sistemaNavegacion = 500;
        private int cantPropulsion;
        private int navegacion;

        public SpaceX(string modelo, int anio, int horasVuelo, int horasService, string color, string duenio, int autonomia, int service)
        {
            id = contadorId++;
            Marca = "SpaceX";
            Modelo = modelo;
            Anio = anio;
            HorasVuelo = horasVuelo;
            HorasService = horasService;
            Color = color;
            Duenio = duenio;
            Autonomia = autonomia;
            Service = (horasVuelo / service);
            CantCargas = (horasVuelo / autonomia);
        }


        public int Id
        {
            get { return id; }
        }
        public int HorasVuelo
        {
            get { return horasVuelo; }
            set { horasVuelo = value; }
        }

        public int HorasService
        {
            get { return horasVuelo; }
            set { horasVuelo = value; }
        }


        #endregion

        #region Funcionalidades
        public override string ToString()
        {
            return $"SpaceX";
        }

        /// <summary>
        /// 
        /// Escaneo()
        /// Funcion abstracta heredada de la clase Vehiculo que retorna un string
        /// Se usan variables para almecenar la cantidad de services
        /// que se le realizaron al SpaceX respecto del checkeo y su kilometraje actual.
        /// Y finalmente devuelve un String elaborado con las variables 
        /// correspondientes a este objeto tesla.
        /// 
        /// </summary>
        public override string Escaneo()
        {
            cantPropulsion = HorasVuelo / sistemaPropulsion;
            return $"Se realizaron {Service} services.\n";
        }
        #endregion
    }
}
