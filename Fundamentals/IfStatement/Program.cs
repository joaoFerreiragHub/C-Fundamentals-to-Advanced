using System;

namespace NestedIf
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isAdmin = false;
            bool isRegistered = true;
            string userName = "";
            Console.WriteLine("Please enter your username");

            userName = Console.ReadLine();

            if (isRegistered && userName != "" && userName.Equals("Admin"))
            {
                Console.WriteLine("Hi there, registered User");
                Console.WriteLine("Hi there, " + userName);
                Console.WriteLine("Hi there, Admin");
            }

            if(isAdmin || isRegistered)
            {
                Console.WriteLine("You are Logged in");
            }
            Console.Read();
        }
    }
}
