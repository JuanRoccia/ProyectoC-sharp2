using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERNANDES_ROCCIA_TAPIA.Entidades
{
    public class Falcon9 : SpaceX
    {
        public Falcon9() 
        {
            Model = "Falcon9";
            Autonomy = 200; // Horas
            ServiceInterval = 400; // Cada 400 horas
        }
    }
}
