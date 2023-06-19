using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    /// cargó solo cuando se uso el 100%, para esto hacemos la cuenta de kmActuales / autonomia.
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
        #region Proiedades
        private static int contadorId = 1;
        private int id;
        private int kmActual;
        private int kmService;
        private int asientos;

        /// <summary>
        /// Contructor, se tiene en cuenta que el modelo es de tipo string,
        /// la unidad de medida de la autonomia es en Kms
        /// los parametros autonomia, asientos y service dependen del modelo de tesla
        /// </summary>
        /// <param name="modelo">modelo del tesla</param>
        /// <param name="anio">año de creacion del vehiculo</param>
        /// <param name="kmActual">kilometraje actual</param>
        /// <param name="kmService">kilometraje en que se debe realizar el proximo service</param>
        /// <param name="color">color del vehiculo</param>
        /// <param name="duenio">porpietario</param>
        /// <param name="autonomia">cantidad de kilometros que el vehiculo puede recorrer con una carga completa de batería</param>
        /// <param name="asientos">cantidad de asientos del vehiculo</param>
        /// <param name="service">cantidad de services que se le realizaron al vehiculo(depende del kmActual)</param>

        public Tesla(string modelo, int anio, int kmActual, string color, string duenio, int autonomia, int asientos, int service)
        {
            id = contadorId++;
            Marca = "Tesla";
            Modelo = modelo;
            Anio = anio;
            KmActual = kmActual;
            kmService = ((kmActual / service) + 1) * service;
            Color = color;
            Duenio = duenio;
            Autonomia = autonomia;
            this.asientos = asientos;
            Service = (kmActual / service);
            CantidadCargas = (kmActual / autonomia);

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

        public int ProximoService
        {
            get { return kmService; }
        }

        //public int Asientos
        //{
        //    get { return asientos; }
        //    set { asientos = value; }
        //}
        #endregion

        

        #region Funcionalidades
        /// <summary>
        /// Metodo abstracto de la clase padre Vehiculo, que es sobreescrito
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"ID: {id}, Marca:{Marca}, Modelo: {Modelo}, Año: {Anio}, Kilometraje Actual: {KmActual}, Kilometraje Service: {ProximoService}, Color: {Color}, Dueño: {Duenio}";
        }

        public override string Escaneo()
        {

            return $"Estoy escaneando un Tesla";
        }
        #endregion
    }
}
