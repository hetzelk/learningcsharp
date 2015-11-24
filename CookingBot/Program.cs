using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingBot
{
    class Program
    {
        static void Main(string[] args)
        {
            ChooseMealTime mealtime = new ChooseMealTime();
            ChooseMealGenre genre = new ChooseMealGenre();
            ChooseMeal mealchoice = new ChooseMeal();
            GoShopping shop = new GoShopping();
            CookItems cook = new CookItems();
            Deliver deliver = new Deliver();

            mealtime.chooseMealTime();
            genre.breakfastGenre();
            genre.lunchGenre();
            genre.dinnerGenre();
            genre.epicGenre();
            mealchoice.breakfastChoice();
            mealchoice.lunchChoice();
            mealchoice.dinnerChoice();
            mealchoice.epicChoice();
            shop.shoppingList();
            cook.getItemOne();
            cook.getItemTwo();
            cook.getItemThree();
            deliver.deliverText();
            Console.ReadLine();
            
        }
    }
}
