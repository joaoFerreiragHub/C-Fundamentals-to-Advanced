using System;

namespace ChallengeStringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 1
            string noValue;
            Console.WriteLine("Please enter your name and press enter");
            noValue = Console.ReadLine();
            Console.WriteLine(noValue.ToUpper());
            //string myNameUpperCase = String.Format("Upper case: {0}", noValue.ToUpper());
            Console.WriteLine(noValue.ToLower());
            Console.WriteLine(noValue.Trim());
            Console.WriteLine(noValue.Substring(2));
        }
    }
}
