using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERNANDES_ROCCIA_TAPIA.Entidades
{
    /// <summary>
    /// Creamos la clase asbtracta vehiculo porque sirve como una clase base que define un conjunto común de 
    /// propiedades y métodos que serán compartidos por todas las clases derivadas 
    /// (como Car, Rocket, TeslaModelX, Starship, etc.). Creamos objetos de sus clases derivadas.
    /// Esto tiene sentido en este caso, porque un "vehículo" es un concepto general, pero luego vamos a crear un 
    /// tipo más específico de vehículo (como un TeslaModelX o un Starship). Entonces nos sirve que la clase Vehicle
    /// sea abstracta porque sirve como una clase base y no quieremos que se instancie directamente.
    /// </summary>
    #region Propiedades
    public abstract class Vehicle
    {
        /// <summary>
        //// OPCIONAL: En vez de usar Kilometraje o Horas de viaje. Podemos usar una medida generica que aplique para
        //// cualquier tipo de vehiculo sin importar si se maneja en horas o km, eso puede ser aclarado luego según
        //// sea necesario, pero el tipo de dato que usemos simepre sera el mismo (si hablamos de numeros enteros).
        //// y ambos se usan para medir distancias.
        /// </summary>
        public int Usage { get; set; } // opcional, puede ser tanto KM como Hs pero el tipo de dato es el mismo.
        public string CompanyLabel { get; set; } // Marca de la comañia, puede ser Tesla o SpaceX ( nose si es necesario )
        public int ID { get; set; } // Identificador único del vehiculo.
        public string Model { get; set; }   // Modelo del vehiculo ( model S, X, Starship, etc ).
        public int Year { get; set; } // Año de fabricación del vehiculo.
        public string Color { get; set; } // Color del vehiculo.
        public string Owner { get; set; } // Dueño del vehiculo, ya sea una persona o empresa.
        public int Autonomy { get; set; } // Autonomía en km para autos, en horas para cohetes
        public int ServiceInterval { get; set; } // Intervalo de servicio en km para autos, en horas para cohetes
        public int Charge { get; set; } // Carga de batería para autos, combustible para cohetes
        #endregion
        /// <summary>
        /// Se crea un metodo abstracto que si o si debera ser implementado por las clases derivadas.
        /// </summary>
        /// <returns></returns>
        public abstract override string ToString();

    }
}
