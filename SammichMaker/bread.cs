using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SammichMaker
{
    class Bread
    {
        public void breadChoice(int breadchoice)
        {
            if (breadchoice == 1)
                Console.WriteLine("Italian Bread");
            else if (breadchoice == 2)
                Console.WriteLine("Wheat Bread");
            else
                Console.WriteLine("Rye Bread");
        }

    }
}
