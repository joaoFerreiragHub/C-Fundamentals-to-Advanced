using System;

namespace ChallengeMethod
{
    class Program
    {

        static void Main(string[] args)
        {
            string friend1 = "Zé";
            string friend2 = "ElMendes";
            string friend3 = "Borgius";
            GreetFriend(friend1);
            GreetFriend(friend2);
            GreetFriend(friend3);
            // GreetFriend(friend1, friend2, friend3);
            Console.Read();
        }

        public static void GreetFriend(string message)
        {

            Console.WriteLine("Hi {0}, my friend!", message);
        }
    }
}
        /* Segunda opção
        public static void GreetFriend(string friendName, string friendName2, string friendName3)
        {

            Console.WriteLine("Hi {0}, my friend!", friendName);
            Console.WriteLine("Hi {1}, my friend!", friendName2);
            Console.WriteLine("Hi {2}, my friend!", friendName3);
        }
*/
