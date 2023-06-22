using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FERNANDES_ROCCIA_TAPIA.Entidades
{
    /// <summary>
    /// La clase Tesla hereda de la clase abstracta vehiculo la cual no se puede
    /// instanciar, para el constructor del tesla se solicitan datos, y acorde esos 
    /// datos y al modelo seleccionado, se asignaran automaticamente
    /// las propiedades asientos, autonomia y service ya que las mismas dependen del modelo.
    /// Por ejemplo si se elige en el comboBox "Modelo X" se asignara =
    ///  asientos:7, autonomia:560 KMS y como service: 1000 KMS
    /// Para la correcta instanciación de los Tesla se crea un constructor.
    /// Para la cantidad de cargas de baterias se tiene en cuenta que la bateria se 
    /// carga solo cuando se usa el 100%, por eso hacemos la cuenta de kmActuales / autonomia.
    /// Para obtener el kilometraje del proximo service se realiza la cuenta
    /// para buscar el siguiente multiplo del service que le corresponda a cada vehiculo
    /// para eso hicimos la cuenta (kmActual / service +1) * service;
    /// A la propiedad Id solo se le creo unicamente un getter y no un setter
    /// para evitar que pueda ser modificado.
    /// Todos los atributos de clase Tesla son declarados como privados
    /// por diseño y encapsulación.
    /// </summary>
    public class Tesla : Vehiculo
    {
        #region Propiedades


        private static int contadorId = 1;
        private int id;
        private int kmActual;
        private int kmService;
        private int asientos;
        private const int controlCinturones = 1000;
        private const int controlBaterias = 2000;
        private const int controlSistemaNavegacion = 2500;
        private const int controlSistemaTraccion = 3000;
        private const int controlMotor = 3000;

        /// <summary>
        /// Contructor, se tiene en cuenta que el modelo es de tipo string,
        /// la unidad de medida de la autonomia es en Kms
        /// los parametros autonomia, asientos y service dependen del modelo de tesla
        /// y se controlan y asignan en la funcion guardarTesla() del FormTesla.
        /// El ID va a simular un número único que depende de un contador que
        /// se autoincrementa cada vez que se instancie un objeto de la clase,
        /// evitando la creación de id's repetidos.
        /// Los teslas tendran una variable Service que informa cada cuantos
        /// kilometros se deben realizar los services.
        /// La variable CantServices que informa cuantos services se le realizaron
        /// al vehiculo y la variable ProximoService que informa
        /// cuando se deberá realizar el proximo service.
        /// la cantidad de services y proximos services depende del kilometraje
        /// del tesla, y del intervalo con el que se deban realizar los mismos
        /// segun el modelo.
        /// </summary>
        /// <param name="modelo"> modelo del tesla</param>
        /// <param name="anio"> año de creacion del vehiculo</param>
        /// <param name="kmActual"> kilometraje actual</param>
        /// <param name="kmService"> kilometraje en que se debe realizar el proximo service</param>
        /// <param name="color"> color del vehiculo</param>
        /// <param name="duenio"> porpietario</param>
        /// <param name="autonomia"> cantidad de kilometros que el vehiculo puede recorrer con una carga completa de batería</param>
        /// <param name="asientos"> cantidad de asientos del vehiculo </param>
        /// <param name="service"> frecuencia en kilometros con la que se realizan los services </param>
        /// <param name="CantServices"> cantidad de services que se le realizaron al vehiculo, depende de la cantidad de kms actuales y la frecuencia de service </param>
        /// <param name="CantCargas"> cantidad de cargas de batería que se le realizaron al tesla, depende de la cantidad de kms actuales y la autonomia</param>

        public Tesla(string modelo, int anio, int kmActual, string color, string duenio, int autonomia, int asientos, int service)
        {
            id = contadorId++;
            Marca = "Tesla";
            Modelo = modelo;
            Anio = anio;
            KmActual = kmActual;
            ProximoService = ((kmActual / service) + 1) * service;
            Color = color;
            Duenio = duenio;
            Autonomia = autonomia;
            Asientos = asientos;
            Service =  service;
            CantServices = (kmActual/ service);
            CantCargas = (kmActual / autonomia);
        }

        public int Id
        {
            get { return id; }
        }
        public int KmActual
        {
            get { return kmActual; }
            set { kmActual = value; }
        }

        public int Asientos
        {
            get { return asientos; }
            set { asientos = value; }
        }
        #endregion

        #region Funcionalidades
        /// <summary>
        /// Metodo abstracto de la clase padre Vehiculo, que es sobreescrito
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"ID: {id}, Marca:{Marca}, Modelo: {Modelo}, Año: {Anio}, Kilometraje Actual: {KmActual}, Kilometraje Service: {ProximoService}, Color: {Color}, Dueño: {Duenio}.";
        }
       
        /// <summary>
        /// 
        /// Escaneo()
        /// Funcion abstracta heredada de la clase Vehiculo que retorna un string
        /// Se usan variables para almecenar la cantidad de services
        /// que se le realizaron al Tesla respecto de su kilometraje actual.
        /// Y finalmente devuelve un String elaborado con las variables 
        /// correspondientes a este objeto tesla.
        /// 
        /// </summary>
        private int cantCinturones;
        private int cantBaterias;
        private int cantNavegacion;
        private int cantTraccion;
        private int cantMotor;
        public override string Escaneo()
        {            
            cantCinturones = kmActual / controlCinturones;
            cantBaterias = kmActual / controlBaterias;
            cantNavegacion = kmActual / controlSistemaNavegacion;
            cantTraccion = kmActual / controlSistemaTraccion;
            cantMotor = kmActual / controlMotor;

            return $"TESLA ID: {Id}.\n" + 
                $"Se realizaron [{CantServices}] services.\n" +
                $"({cantCinturones}) Controles de cinturones de seguridad.\n" +
                $"({cantBaterias}) Controles de baterias.\n"+
                $"({cantNavegacion}) Controles del Sistema de Navegación.\n" +
                $"({cantTraccion}) Controles del Sistema de Tracción.\n" +
                $"({cantMotor}) Controles de Motor.\n";
        }
        #endregion
        
    }
}
