using System;

namespace Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
          

            // Implicit Conversion

            int num = 123456789;
            long bigNum = num;

            float myFloat = 13.37f;
            double myNewDouble = myFloat;

            double myDouble = 13.37;
            int myInt;
           
            // Explicit Conversion
            // Cast double to int;

            myInt = (int)myDouble;

            // Type Conversion

            string myString = myDouble.ToString(); //"13.37"
            string otherString = myFloat.ToString();
            bool sunIsShining = false;

            string myBoolString = sunIsShining.ToString();

            Console.WriteLine(myInt);
            Console.WriteLine(myString);
            Console.WriteLine(otherString);
            Console.WriteLine(myBoolString);



        }
    }
}
