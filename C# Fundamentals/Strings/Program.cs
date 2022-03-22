using System;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Joao";
            string lastName = "Ferreira";
            string fullName = string.Concat(" ",firstName, lastName," ");
            Console.WriteLine(firstName.Substring(2)); // ao
            Console.WriteLine(firstName.ToLower()); //joao
            Console.WriteLine(firstName.ToUpper()); //JOAO
            Console.WriteLine(fullName.Trim()); //JoaoFerreira
            Console.WriteLine(firstName.IndexOf("a")); //2

        }
    }
}
