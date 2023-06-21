using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERNANDES_ROCCIA_TAPIA.Entidades
{
    public class ModelS : Tesla
    {
        public ModelS()
        {
            Model = "Model S";
            Autonomy = 650; // Kilometros
            Seats = 5;
            ServiceInterval = 2000; // Cada 2000 Kilometros
        }
    }
}
