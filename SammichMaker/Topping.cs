using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SammichMaker
{
    class Topping
    {
        public string toppingChoice(int toppingchoice)
        {
            if (toppingchoice == 1)
                return "Cheese";
            else if (toppingchoice == 2)
                return "Lettuce";
            else if (toppingchoice == 3)
                return "Salt";
            else
                return "Pepper";
        }
    }
}
