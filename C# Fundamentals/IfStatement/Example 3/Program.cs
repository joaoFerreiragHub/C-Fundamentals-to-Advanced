using System;

namespace ChallengeStringMethods2
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString;
            char secondString;

            Console.WriteLine("Enter a String here: ");
            firstString = Console.ReadLine();
            Console.WriteLine("Enter the character to search: ");
            secondString = Console.ReadLine()[0];

            int searchIndex = firstString.IndexOf(secondString);
            Console.WriteLine("The index of the first occurrence is: ",secondString, searchIndex);


            string firstName;
            string lastName;

            Console.WriteLine("Write your first Name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Write your Last Name: ");
            lastName = Console.ReadLine();
            //Console.WriteLine("Here's your full name: {0} {1}", firstName, lastName);
            string fullName = String.Concat(firstName, " ", lastName);
            Console.WriteLine("Your full name is {0}", lastName);
        }
    }
}
