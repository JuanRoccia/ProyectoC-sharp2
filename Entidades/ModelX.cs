using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERNANDES_ROCCIA_TAPIA.Entidades
{
    public class ModelX : Tesla
    {
        public ModelX()
        {
            Model = "Model X";
            Autonomy = 560; // Kilometros
            Seats = 7;
            ServiceInterval = 1000; // Cada 1000 Kilometros
        }
    }
}
