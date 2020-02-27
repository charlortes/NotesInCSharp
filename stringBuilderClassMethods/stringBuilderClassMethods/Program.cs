using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringBuilderClassMethods
{
    class Program
    {
        static void Main(string[] args)
        {// "StringBuilder" is a class in C#, which means it has properties and methods; we use it to modify strings
            StringBuilder exString = new StringBuilder();

            exString.Append('-', 6);// to append something is to add to it, simillar to concatinating?
            exString.Append("What a title!");
            exString.Append('-', 6);// its nice that you can have the same line say differnt things based on differnt outcomes

            Console.WriteLine(exString);

            //more efficient way to do it, no need to skip to the next line

            StringBuilder exString02 = new StringBuilder("Hi there.");
            exString02.Append(" How are you today?").AppendLine().Append("I am great!"); 
            //whats hapening here is i am inserting more lines into the string, appendLine is the same as writeline, it skips to the next line, hence leaving it blank.
            
            Console.WriteLine(exString02);

            
        }
    }
}
