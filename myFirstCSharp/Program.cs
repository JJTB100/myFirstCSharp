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

            // Input number of pizzas
            int numOfPizzas = int.Parse(Console.ReadLine());

            // Loop
            for (int i = 0; i < numOfPizzas; i++) 
            {
                // Display the text, with an incrementing number
                Console.WriteLine("Eat Pizza Number " + (i+1)); 
            }

        }
    }
}
