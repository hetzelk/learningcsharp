using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SammichMaker
{
    class Bread
    {
        public string breadChoice(int breadchoice)
        {
            if (breadchoice == 1)
                return "Italian Bread";
            else if (breadchoice == 2)
                return "Wheat Bread";
            else if (breadchoice == 3)
                return "Rye Bread";
            else
                return "Please enter a number 1-3";
        }

        //public 

    }
}
