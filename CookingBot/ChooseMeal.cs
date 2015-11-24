using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingBot
{
    class ChooseMeal
    {
        public void breakfastChoice1()
        {
            Console.WriteLine("[1] - Frosted Flakes");
            Console.WriteLine("[2] - Cheerios");
            Console.WriteLine("[3] - Fruity Pebbles");
            Console.WriteLine("[4] - Captain Crunch Berries");
        }

        public void breakfastChoice2()
        {
            Console.WriteLine("[1] - Pancakes w/ eggs + Bacon");
            Console.WriteLine("[2] - French Toast w/eggs + bacon");
            Console.WriteLine("[3] - Waffles w/eggs + bacon");
            Console.WriteLine("[4] - Lumberjack Slam");
        }
        public void breakfastChoice3()
        {
            Console.WriteLine("[1] - Pancake Taco w/ egg + sausage");
            Console.WriteLine("[2] - Pancake Taco w/ egg + bacon");
            Console.WriteLine("[3] - Waffle Taco w/ egg + sausage");
            Console.WriteLine("[4] - Waffle Taco w/ egg + bacon");
        }
        public void lunchChoice1()
        {
            Console.WriteLine("[1] - Microwaved Pizza");
            Console.WriteLine("[2] - Microwaved Salisbury Steak");
            Console.WriteLine("[3] - Microwaved Chicken Pot Pie");
            Console.WriteLine("[4] - Microwaved Leftovers");
        }

        public void lunchChoice2()
        {
            Console.WriteLine("[1] - Macaroni and Cheese");
            Console.WriteLine("[2] - Pesto");
            Console.WriteLine("[3] - Velveta with bacon");
            Console.WriteLine("[4] - ");
        }

        public void lunchChoice3()
        {
            Console.WriteLine("[1] - Ham Sammich");
            Console.WriteLine("[2] - Ham Sammich with bacon");
            Console.WriteLine("[3] - Ham Sammich with extra bacon");
            Console.WriteLine("[4] - Ham Sammich with Epic Meal Time amount of bacon");
        }

        public void dinnerChoice1()
        {
            Console.WriteLine("[1] - Chicken Parnesan");
            Console.WriteLine("[2] - Pesto");
            Console.WriteLine("[3] - Deluxe Macaroni and Cheese");
            Console.WriteLine("[4] - ");
        }

        public void dinnerChoice2()
        {
            Console.WriteLine("[1] - Cheese Pizza");
            Console.WriteLine("[2] - Pepperoni Pizza");
            Console.WriteLine("[3] - Sausage Pizza");
            Console.WriteLine("[4] - The Works Deluxe Pizza");
        }

        public void dinnerChoice3()
        {
            Console.WriteLine("[1] - Sushi");
            Console.WriteLine("[2] - Stir Fry");
            Console.WriteLine("[3] - Chinese Egg Foo Yung");
            Console.WriteLine("[4] - ");
        }

        public void epicChoice()
        {
            Console.WriteLine("[1] - Stadium Sized Crackers and Cheese");
            Console.WriteLine("[2] - The Bacon Bacon Bacon Burger");
            Console.WriteLine("[3] - Massive Pizza made with bacon");
            Console.WriteLine("[4] - Grande Bacon Tacos");
        }
    }
}
