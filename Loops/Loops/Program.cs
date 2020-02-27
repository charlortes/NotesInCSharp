using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
             //for loops

            for (int i = 1; i <= 10; i++) //in a for loop, the program will run until the condition is no longer met
            {                             //for as long as i <= 100, keep adding 1 and looping
                Console.WriteLine(i);
            }

            // project- write all even numbers between 0-100

            for (int x = 1; x <= 100; x++)
            {
                if (x % 2 == 0)
                {
                    Console.Write(x + ", ");
                }
                    
            }
            Console.WriteLine();
            //while loops

            int y = 1;

            while (y <= 10)
            {
                Console.WriteLine(y);
                y++;
            }

            //make something to count the number of throws it takes to get a die roll

            Random numGen = new Random();
            int numOfAttempts = 0;
            int attempt = 0;

            while (attempt != 6)
            {
                attempt = numGen.Next(1, 7);
                Console.WriteLine("You rolled a {0}", attempt);
                numOfAttempts++;
            }
            Console.WriteLine("it took you {0} attempts to roll a 6", numOfAttempts);

            //gambling game?

            // do while loops are similar but less commonly used, you'd use a do while loop if you were sure your program 
            //would loop at least once.
        }
    }

}
