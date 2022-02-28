using System;

namespace ChallengeArray2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isValid = false;
            string inputValueType = "Unkown";

            Console.WriteLine("Type something");
            string input = Console.ReadLine();

            Console.WriteLine("Select a Type of Data: \n String \n Integer \n Bool");
            string inputType = Console.ReadLine();

            switch(inputType)
            {
                case "1":
                    isValid = CheckString(input);
                    inputValueType = "String";
                    break;
                case "2":
                    int num = 0;
                    isValid = int.TryParse(input, out num);
                    inputValueType = "Integer";
                    break;
                case "3":
                    bool isBool = false;
                    isValid = bool.TryParse(input, out isBool);
                    inputValueType = "Bool";
                    break;
                default:
                    Console.WriteLine("Something went wrong!");
                    break;
            }

            Console.WriteLine("You have entered a value : {0}", input);
            if (isValid)
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
            foreach(char c in value)
            {
                if(!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
