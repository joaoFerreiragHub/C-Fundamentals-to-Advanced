using System;

namespace ChallengeDataTypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            byte myByte = 25;
            Console.WriteLine(myByte);
            sbyte mySbyte = -15;
            Console.WriteLine(mySbyte);
            int myInt = -12318925;
            Console.WriteLine(myInt);
            uint myUint = 123091;
            Console.WriteLine(myUint);
            short myShort = -32768;
            Console.WriteLine(myShort);
            ushort myUShort = 65535;
            Console.WriteLine(myUShort);
            float myFloat = -31.1289f;
            Console.WriteLine(myFloat);
            double myDouble = -12.1231250;
            Console.WriteLine(myDouble);
            char myCharacter = 'A';
            Console.WriteLine(myCharacter);
            bool myBool = true;
            Console.WriteLine(myBool);
            string myText = "I control text";
            Console.WriteLine(myText);
            string numText = "15";

            string value1 = "I control text";
            string value2 = "32";

            int value2int = Int32.Parse(value2);

            Console.WriteLine("First String: {0}", value1);
            Console.WriteLine("Second String, but now int: {0}", value2int);
        }
    }
}
