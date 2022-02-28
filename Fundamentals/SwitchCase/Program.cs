using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 25;

            switch(age)
            {
                case 15:
                    Console.WriteLine("Too young to party in the club!");
                    break;
                case 25:
                    Console.WriteLine("Good to go!");
                    break;
                default: 
                    Console.WriteLine("How old are you?");
                    break;
            }

            string userName = "Joao";

            switch (userName)
            {
                case "Joao":
                    Console.WriteLine("Username is Joao");
                    break;
                case "Root":
                    Console.WriteLine("Username is Root");
                    break;
                default:
                    Console.WriteLine("Username is Unknown");
                    break;
            }
            Console.Read();
            
        }
    }
}
