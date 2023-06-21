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
    public class Tesla : Vehicle
    {
        #region Proiedades
        public int Seats { get; set; } // Número de asientos

        #endregion

        #region Funcionalidades
        /// <summary>
        /// Metodo abstracto de la clase padre Vehiculo, que es sobreescrito
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"ID: {ID}, Marca:{CompanyLabel}, Modelo: {Model}, Año: {Year}, Kilometraje Actual: {Usage}, Kilometraje Service: {ServiceInterval}, Color: {Color}, Dueño: {Owner}";
        }
        #endregion
    }
}
