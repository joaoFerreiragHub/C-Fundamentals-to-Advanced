using System;

namespace Constants
{
    class Program
    {

        // constants as fields

        const double PI = 3.14159265359;
        const int weeks = 52, months = 12;

        // create a constant of type string with you birthday as its value

        const string birthday = "23/06/1990";


        static void Main(string[] args)
        {
            Console.WriteLine("My birthday is always going to be: {0}", birthday);
            Console.Read();
        }
    }
}
