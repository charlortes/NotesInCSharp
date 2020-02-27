using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] evenNumbers = new int[3]; //by giving it the brackets, we signify that it is an array of ints

            evenNumbers[0] = 0;             //list you dimensions in the array, and define them
            evenNumbers[1] = 2;
            evenNumbers[2] = 4;

            Console.WriteLine(evenNumbers[1]); // call the array and specify which dimension you want to grab

            // you can initialize and assign values in the same line
            int[] oddNumbers = {1, 3, 5};

            Console.WriteLine(oddNumbers[2]);
        }
    }
}
