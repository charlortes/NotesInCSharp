using System;
using System.Collections.Generic;
using System.Text;

namespace StringClassMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //string is a class, which means it has proporties and methods
            String exampleText = "Charlotte is learning about strings, how is she doing?";

            Console.WriteLine(exampleText.ToLower()); //handy when you need to compare strings but case sensitivity doesnt matter

            Console.WriteLine(exampleText.Trim());// gets rid of unnecessesary spacing

            Console.WriteLine(exampleText.IndexOf("is")); //searches for how far in a string the first instance of a phrase is
            Console.WriteLine(exampleText.LastIndexOf("is"));// searches how far the last instance of a phrase is

            Console.WriteLine(exampleText.Substring(2, 4)); // goes to the third precision in the string, then grabs the next 4 digits
            Console.WriteLine(exampleText.Replace("is she", "are they"));//replaces all instances of the quoted string with the desired string
            Console.WriteLine(exampleText.Insert(54, " ok, i guess"));// inserts a string after the described point

            Console.WriteLine(string.IsNullOrEmpty(exampleText)); //checks with true or false if there was anything in the string

            //when user input is given as a string, parse it to check if 
            string stringNumber = "1991";
            int intNumber = int.Parse(stringNumber);
            int intNumber2 = Convert.ToInt32(stringNumber);

        }
    }
}
