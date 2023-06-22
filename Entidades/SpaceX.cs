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
        private int HsVueloActual;
        private int horasService;
        private const int sistemaPropulsion = 1000;
        private const int sistemaNavegacion = 500;
        private int cantPropulsion;
        private int cantNavegacion;

        public SpaceX(string modelo, int anio, int hsVueloActual, string color, string duenio, int autonomia, int service)
        {
            id = contadorId++;
            Marca = "SpaceX";
            Modelo = modelo;
            Anio = anio;
            HsVueloActual = hsVueloActual;
            horasService = (hsVueloActual + service); // Para calcular el proximo service
            Color = color;
            Duenio = duenio;
            Autonomia = autonomia;
            CantServices = (HsVueloActual / service); // Para mostrar la  cantidad de service total realizados
            CantCargas = (HsVueloActual / autonomia);
            IntervaloService = service; // Para mostrar el intervalo de service corrspondiente a cada modelo
        }


        public int Id
        {
            get { return id; }
        }
        public int HorasVueloActual
        {
            get { return HsVueloActual; }
            set { HsVueloActual = value; }
        }

        public int ProximoService // para obtener el proximo service
        {
            get { return horasService; }
        }
        #endregion

        #region Funcionalidades
        public override string ToString()
        {
            return $"ID: {ID}, Marca:{CompanyLabel}, Modelo: {Model}, Año: {Year}, Horas de Vuelo Actual: {Usage}, Service: {ServiceInterval}, Color: {Color}, Empresa: {Owner}";
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
            cantPropulsion = HsVueloActual / sistemaPropulsion;
            cantNavegacion = HsVueloActual / sistemaNavegacion;

            string reporte = 

                $"SpaceX {Modelo} | ID: {Id} | Horas de vuelo: {HorasVueloActual}hs | Service cada: {IntervaloService}hs\n" +
                $"Control del Sistema de Propulsion: cada 1000Hs\n" +
                $"Control del Sistema de Navegacion: cada 500Hs\n\n" +
                $"Se realizaron [{CantServices}] servicios.\n" +
                $"({cantPropulsion}) Controles del Sistema de Propulsión.\n" +
                $"({cantNavegacion}) Controles del Sistema de Navegación.";

            return reporte;
        }
        #endregion
    }
}
