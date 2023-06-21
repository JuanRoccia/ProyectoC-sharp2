using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERNANDES_ROCCIA_TAPIA.Entidades
{
    public class Starship : SpaceX
    {
        public Starship()
        {
            Model = "Starship";
            Autonomy = 500; // Horas
            ServiceInterval = 1000; // Cada 1000 Horas
        }
    }
}
