
using System;

namespace ChallengeArray
{
    class Program
    {
        static void Main(string[] args)
        {
            bool valid = false;
            string inputType;
            string inputValueType;
            inputValueType = "Unkown";

            Console.WriteLine("Type something:");
            string input = Console.ReadLine();

            Console.WriteLine("Select the data Type:\n 1- String \n 2- Integer \n 3- Boolean");
            inputType = Console.ReadLine();

            if (inputType == "1")
            {
                valid = CheckString(input);
                Console.WriteLine("You Typed a String: {0}", input);
                inputValueType = "String";

            }
            else if (inputType == "2")
            {
                int num = 0;
                valid = int.TryParse(input, out num);
                Console.WriteLine(" You typed an Integer: {0}", num);
                inputValueType = "Integer";

            }
            else if (inputType == "3")
            {
                bool isBool = false;
                valid = bool.TryParse(input, out isBool);
                Console.WriteLine(" You typed an Integer: {0}", isBool);
                inputValueType = "Bool";
            }
            else
            {
                Console.WriteLine("Something is Wrong!");
            }

            Console.WriteLine("You have entered a value : {0}", inputValueType);
            if(valid)
            {
                Console.WriteLine("It is Valid : {0}", inputValueType);
            }
            else
            {
                Console.WriteLine("It is an invalid : {0}", inputValueType);
            }

            Console.ReadKey();

        }
        static bool CheckString(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsLetter(c))
                    return false;    
            }
            return true;
        }
    }
}
