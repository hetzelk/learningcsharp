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

    class UserInput
    {
        public void breadChoices()
        {
            Bread bread = new Bread();
            Console.WriteLine("Please enter a choice for bread");
            string breadchoice1 = Console.ReadLine();
            int breadchoice = Convert.ToInt32(breadchoice1);
            Console.WriteLine(bread.breadChoice(breadchoice));
            Console.ReadLine();
        }

        public void toastedChoices()
        {
            Toasted toast = new Toasted();
            Console.WriteLine("Would you like it toasted? Y or N");
            string toastchoice = Console.ReadLine();
            Console.WriteLine(toast.toastChoice(toastchoice));
            Console.ReadLine();
        }

        public void meatChoices()
        {
            Meat meat = new Meat();
            Console.WriteLine("Please enter a choice for meat");
            string meatchoice1 = Console.ReadLine();
            int meatchoice = Convert.ToInt32(meatchoice1);
            Console.WriteLine(meat.meatChoice(meatchoice));
            Console.ReadLine();
        }

        public void toppingChoices()
        {
            Topping topping = new Topping();
            Console.WriteLine("Please enter a choice for toppings");
            string toppingchoice1 = Console.ReadLine();
            int toppingchoice = Convert.ToInt32(toppingchoice1);
            Console.WriteLine(topping.toppingChoice(toppingchoice));
            Console.ReadLine();
        }

        public void sideChoices()
        {
            Side side = new Side();
            Console.WriteLine("Please enter a choice for a side");
            string sidechoice1 = Console.ReadLine();
            int sidechoice = Convert.ToInt32(sidechoice1);
            Console.WriteLine(side.sideChoice(sidechoice));
            Console.ReadLine();
        }
    }
}
