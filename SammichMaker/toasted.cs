using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SammichMaker
{
    class Toasted
    {
        public string toastChoice(string toastchoice)
        {
            if (toastchoice == "Y")
                return "Toasted";
            else if (toastchoice == "N")
                return "Not Toasted";
            else
                return "Please enter a correct choice";
        }

    }
}
