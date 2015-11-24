using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingBot
{
    class ChooseMealGenre
    {
        public void breakfastGenre()
        {
            Console.WriteLine("[1] - Cereal");
            Console.WriteLine("[2] - Pancakes/French Toast/Waffles");
            Console.WriteLine("[3] - ");
            Console.WriteLine("[4] - Breakfast Tacos");
        }

        public void lunchGenre()
        {
            Console.WriteLine("[1] - Microwaved");
            Console.WriteLine("[2] - Noodles");
            Console.WriteLine("[3] - Sandwiches");
            Console.WriteLine("[4] - Fast Food");
        }

        public void dinnerGenre()
        {
            Console.WriteLine("[1] - Pasta");
            Console.WriteLine("[2] - Pizza");
            Console.WriteLine("[3] - Gourmet");
            Console.WriteLine("[4] - Fast Food");
        }

        public void epicGenre()
        {
            Console.WriteLine("[1] - Epic");
            Console.WriteLine("[2] - Epic");
            Console.WriteLine("[3] - Epic");
            Console.WriteLine("[4] - Or Epic");
        }
    }
}
