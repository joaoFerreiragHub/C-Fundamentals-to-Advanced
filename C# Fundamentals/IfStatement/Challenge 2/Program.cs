using System;

namespace ChallengeLogIn
{

    class Program
    {
        static string userName;
        static string userPass;

        static void Main(string[] args)
        {
            Register();
            Login();
            Console.Read();
        }

        public static void Register()
        {
            Console.WriteLine("Register your UserName: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Register your Password:");
            string userPass = Console.ReadLine();
            Console.WriteLine("Registration Completed!");
        }

        public static void Login()
        {
            Console.WriteLine("Enter your UserName: ");
            if (userName == Console.ReadLine())
            {
                Console.WriteLine("Register your Password:");
                if (userPass == Console.ReadLine())
                {
                    Console.WriteLine("You are logged in!");
                }
                else
                {
                    Console.WriteLine("Wrong Password!");
                }
            }
            else
            {
                Console.WriteLine("Wrong UserName try again!");
            }
        }
    }
}
