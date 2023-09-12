using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workingWithCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberVolume = 100;
            Console.WriteLine("What's your random number");
            var userResponse = Console.ReadLine();
            if (int.TryParse(userResponse, out numberVolume)) //I'm trying to cast (the string value from the user input into an int by using TryParse()); 
            {
                Console.WriteLine("Hey you're successful!");
            }
            else
            {
                Console.WriteLine("Try a number next time!");
            }
            Console.WriteLine("Enter any key to continue....");
            Console.ReadKey();
        }
    }
}
