using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirstCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many pizzas would you like to eat?");
            int numOfPizzas = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfPizzas; i++)
            {
                Console.WriteLine("Eat Pizza Number " + (i+1));
            }

        }
    }
}
