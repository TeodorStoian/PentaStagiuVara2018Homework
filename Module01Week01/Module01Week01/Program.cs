using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module01Week01
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            int rngNumber = rng.Next(0, 101);
            int guess = 0;

            while (guess != rngNumber)
            {
                Console.Write("Try to guess my random generated number from 1 to 100:");
                int.TryParse(Console.ReadLine(), out guess);

                if (guess > rngNumber)
                {
                    Console.WriteLine($"Your guess ({guess}) is too big!");
                }
                else if (guess < rngNumber)
                {
                    Console.WriteLine($"Your guess ({guess}) is too small!");
                }
                else
                {
                    Console.WriteLine($"Good job! {guess} is the correct number!");
                }

            }
        }
    }
}
