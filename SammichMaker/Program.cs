using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SammichMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInput ui = new UserInput();
            ui.breadChoices();
            ui.toastedChoices();
            ui.meatChoices();
            ui.toppingChoices();
            ui.sideChoices();
        }

    }

}
