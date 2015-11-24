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
                return "Ham";
            else if (breadchoice == 2)
                return "Chicken";
            else
                return "Salami";
        }

    }
}
