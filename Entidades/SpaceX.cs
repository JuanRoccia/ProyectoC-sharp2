using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERNANDES_ROCCIA_TAPIA.Entidades
{
    public class SpaceX : Vehicle
    {

        #region Propiedades
        
        #endregion

        public override string ToString()
        {
            return $"ID: {ID}, Marca:{CompanyLabel}, Modelo: {Model}, Año: {Year}, Horas de Vuelo Actual: {Usage}, Service: {ServiceInterval}, Color: {Color}, Empresa: {Owner}";
        }
    }
}
