﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FERNANDES_ROCCIA_TAPIA.Entidades
{
    /// <summary>
    /// La clase padre abstracta Vehiculo, se declara teniendo
    /// en cuenta la futura implementacion de vehiculos que tienen propiedades en común.
    /// Se implementa esta idea para no generar codigo, ni propiedades redundantes en el
    /// programa, y para que esta calse pueda ser reutilizada
    /// en futuros vehiculos y/o marcas.
    /// Se tiene en cuenta que la autonomia, y los services seran medidos
    /// en la medida especifica de cada dato, en este caso para la clase
    /// Tesla estas propiedades haran referencia a los kilometros,
    /// mientras que en la clase SpaceX hara referencia a las horas.
    /// La propiedad cantCargas se utilizara para el enunciado 5
    /// "Mostrar la cantidad de carga de baterias/combustible de todos los vehiculos"
    /// donde se tendra en cuenta la autonomia de cada vehiculo y dependendiendo
    /// de la autonomia y los kms, horas de vuelo del vehiculo. 
    /// Se hará la cuenta de kms/autonomia u hs/autonomia para evaluar
    /// cuantas veces se cargo la bateria, o cuantos tanques de combustible
    /// se cargaron. Pero estos valores no van a poder ser modificados, sino que
    /// seran asignados automaticamente, acorde a las solicitudes y resultantes
    /// de las cuentas correspondientes.
    /// Todos los atributos de la clase Vehiculo son declarados privados
    /// para que unicamente puedan ser accedidos mediante sus metodos.
    /// Con esto cumplimos con la encapsulación de la POO.
    /// </summary>
    #region Propiedades
    public abstract class Vehiculo
    {
        private string marca;
        private string modelo;
        private int anio;
        private int autonomia;
        private string color;
        private string duenio;
        private int service;
        private int cantCargas;

        //GETTERS & SETTERS

        public int CantidadCargas
        {
            get { return cantCargas; }
            set { cantCargas = value; }
        }
        public int Service
        {
            get { return service; }
            set { service = value; }
        }


        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public int Anio
        {
            get { return anio; }
            set { anio = value; }
        }

        public int Autonomia
        {
            get { return autonomia; }
            set { autonomia = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public string Duenio
        {
            get { return duenio; }
            set { duenio = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }


        #endregion

        /// <summary>
        /// Se crea un metodo abstracto que si o si debera ser implementado
        /// por las clases derivadas.
        /// </summary>
        /// <returns></returns>
        public abstract override string ToString();

        public abstract string Escaneo();

    }
}
