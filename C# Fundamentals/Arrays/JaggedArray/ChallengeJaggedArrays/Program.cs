using System;

namespace ChallengeJaggedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] jaggedArray = new string[][]
            {
                new string[]{"Parents","Brothers"},
                new string[]{"Uncles", "Cousins" },
                new string[]{"Grandparents"}
            };

            
            Console.WriteLine("Hi {0}, i would like to introduce to you {1}", jaggedArray[1][0], jaggedArray[0][1]);
            Console.WriteLine("Hi {0}, i would like to introduce to you {1}", jaggedArray[2][0], jaggedArray[0][0]);
            Console.WriteLine("Hi {0}, i would like to introduce to you {1}", jaggedArray[0][0], jaggedArray[1][1]);
        }
    }
}
