using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {//but first, random number generator!

            Random numGenerator = new Random();//syntax is weird. i wonder if anything can go in here?
            Random numGenerator2 = new Random();
            int num01 = numGenerator.Next(1, 11); // min value is inclusive, max value isnt
            int num02 = numGenerator2.Next(1, 11);

            Console.WriteLine("What is {0} times {1}?", num01, num02);
            int answer = Convert.ToInt32(Console.ReadLine());

            if (num01 * num02 == answer)
            {
                Console.WriteLine("Good Job!");
            }
            else
            {
                int responseIndex = numGenerator.Next(1, 4);

                switch(responseIndex)
                {
                    case 1:
                        Console.WriteLine("Are you even trying?");
                        break; //interesting. case, break. handy
                    case 2:
                        Console.WriteLine("Get good");
                        break;
                    default: // also interesting, could come in handy with loot to have a default. kind of like the final else in an if else statement.
                        Console.WriteLine("Better luck next time");
                        break;
                }
            }


        }
    }
}
