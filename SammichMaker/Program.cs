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
            Bread bread = new Bread();
            Toasted toast = new Toasted();
            Meat meat = new Meat();
            Topping topping = new Topping();
            Side side = new Side();

            Console.WriteLine("Please enter a choice for bread");
            string breadchoice1 = Console.ReadLine();
            int breadchoice = Convert.ToInt32(breadchoice1);
            bread.breadChoice(breadchoice);
            Console.ReadLine();
        }
    }
}
