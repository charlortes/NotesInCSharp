using System;

namespace DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            // paramaters mean: (year, month, day, hour, minute, second)

            var date01 = new DateTime(2008, 5, 1, 8, 30, 52);
            Console.WriteLine(date01);


            //DateTime properties

            var date02 = DateTime.Now;
            var date03 = DateTime.UtcNow;
            var date04 = DateTime.Today;

            Console.WriteLine(date03);

            //DateTime methods
            // adding or subtracting days/time 

            var tomorrow = date02.AddDays(-1); // works with positive or negative
            var inAnHour = date02.AddHours(1);
            Console.WriteLine(tomorrow);
            Console.WriteLine(inAnHour);

            //DateTime formats
            Console.WriteLine(date02.ToLongDateString()); // ex. Thursday, February 20, 2020
            Console.WriteLine(date02.ToShortDateString());// ex. 2/20/2020
            Console.WriteLine(date02.ToLongTimeString());// ex. 6:40:16
            Console.WriteLine(date02.ToShortTimeString());// ex. 6:40

            //custome DateTime format
            Console.WriteLine(date02.ToString());
            Console.WriteLine(date02.ToString("yy-MM-dd")); //various ways to do this, case sensitive. check ToString() parameters.
                                                            //https://docs.microsoft.com/en-us/dotnet/api/system.datetime.tostring?view=netframework-4.8

        }
    }
}
