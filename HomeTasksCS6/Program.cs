using System;
using HomeTasks6C;

namespace HomeTasksCS6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Product pr = new Product();
            pr.Name = "Test";
            Console.WriteLine(pr.Name);

            Drink drink = new Drink();

            pr.Price = 82;
            drink.AlcoholPercent = 45;

            Console.WriteLine(pr.Price);
            Console.WriteLine(drink.AlcoholPercent);


        }

        
    }
}
