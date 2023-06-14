﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERNANDES_ROCCIA_TAPIA.Entidades
{
    public class SpaceX : Vehiculo
    {

        #region Propiedades
        private static int contadorId = 0;
        private int id;
        private int horasVuelo;
        private int horasService;

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
            Service = service;
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

        public override string ToString()
        {
            return $"SpaceX";
        }
    }
}
