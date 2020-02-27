using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            Console.WriteLine("I'm thinkning of a number between 1 and 100. Can you guess it?");
            int answer = Convert.ToInt32 (Console.ReadLine());

            if (answer == 69)
            {
                Console.WriteLine("Nice");
            }
            else if (answer == 420)
            {
                Console.WriteLine("You broke the rules, but im not debugging this. you still win.");
            }
            else
            {
                Console.WriteLine("Try again.");
                goto Start;
            }

        }
    }
}
