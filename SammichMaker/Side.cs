using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SammichMaker
{
    class Side
    {
        public string sideChoice(int sidechoice)
        {
            if (sidechoice == 1)
                return "Goldfish"; 
            else if (sidechoice == 2)
                return "Lays Chips";
            else
                return "Doritos";
        }
    }
}
