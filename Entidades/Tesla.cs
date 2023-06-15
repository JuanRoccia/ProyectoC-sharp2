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
    /// Para la correcta instanciación de los Tesla se crea un constructor
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
        /// </summary>
        /// <param name="modelo"></param>
        /// <param name="anio"></param>
        /// <param name="kmActual"></param>
        /// <param name="kmService"></param>
        /// <param name="color"></param>
        /// <param name="duenio"></param>
        /// <param name="autonomia"></param>
        /// <param name="asientos"></param>
        public Tesla(string modelo, int anio, int kmActual, string color, string duenio, int autonomia, int asientos, int service)
        {
            id = contadorId++;
            Marca = "TESLA";
            Modelo = modelo;
            Anio = anio;
            KmActual = kmActual;
            KmService = kmService;
            Color = color;
            Duenio = duenio;
            Autonomia = autonomia;
            Asientos = asientos;
            Service = service;

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

        public int KmService
        {
            get { return kmService; }
            set { kmService = value; }
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
            return $"ID: {id}, Marca:{Marca}, Modelo: {Modelo}, Año: {Anio}, Kilometraje Actual: {KmActual}, Kilometraje Service: {KmService}, Color: {Color}, Dueño: {Duenio}";
        }
        #endregion
    }
}
