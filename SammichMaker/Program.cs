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

            //pick from 4 choices to build your sandwich
            //bread, pick one = italian(white), wheat, rye
            //toasted, pick one = yes or no
            //meat, pick as many as you want, but only one of each = Ham, Chicken, Salami
            //topping, pick as many as you want, but only one of each  = cheese, lettuce, salt, pepper, butter
            //side, pick one = goldfish, lays chips, doritos
        }
    }
}
