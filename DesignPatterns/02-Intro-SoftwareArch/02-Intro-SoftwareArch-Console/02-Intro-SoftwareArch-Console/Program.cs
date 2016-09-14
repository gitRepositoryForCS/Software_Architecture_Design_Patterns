using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_SoftwareArch_Console
{
    class Program
    {

        // echos the user's name and prints a randomly chosen int:
        static void Main(string[] args)
        {
            Console.Write("Guess an int, M, in range 0..10: M = ");
            string s = Console.ReadLine();
            int m = Int32.Parse(s);
            Console.Write("I guess int, N, in range 0..10-M: N = ");

            // how to generate random numbers:
            Random r = new Random();
            int min = 0;
            int max = 10;
            int n = r.Next(min, max + 1);

            Console.WriteLine(n);
           // Console.WriteLine("Here is a random generated number between {0} to {1}: {2}", min, max, n);
            Console.WriteLine("now you type an int, P, such that M + N + P = 10: P = ");
            // retain command window till user presses Enter
            string x = Console.ReadLine();
            int p = Int32.Parse(x);
           
            if (m + n + p == 10)
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("You lose!");
            }

            Console.ReadLine();
        }
    }
}
