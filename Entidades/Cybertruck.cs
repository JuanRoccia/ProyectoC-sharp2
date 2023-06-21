using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERNANDES_ROCCIA_TAPIA.Entidades
{
    public class Cybertruck : Tesla
    {
        public Cybertruck()
        {
            Model = "Cybertruck";
            Autonomy = 800; // Kilometros
            Seats = 6;
            ServiceInterval = 3000; // Cada 3000 Kilometros
        } 
    }
}
