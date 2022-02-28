using System;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            ParamsMethod("this", "is", "a", "me", "trying", "params");
            ParamsMethod2("Hello",13,'#');*/
            int min = MinV2(6, 7, 8, 9, 10, 65, 4, 3, 2, 1);
            Console.WriteLine("Minimum is {0} ", min);
        }

        public static int MinV2(params int[] numbers)
        {
            int min = int.MaxValue;

            foreach (int number in numbers)
            {
                if (number < min)
                {
                    min = number;
                }
                

            }
            return min;
        }
        /*
        public static void ParamsMethod(params string[] sentence)
        {
            for (int i = 0; i < sentence.Length; i++)
            {
                Console.WriteLine(sentence[i] + " ");
            }
        }

        public static void ParamsMethod2(params object[] stuff)
        {
            foreach (object obj in stuff)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }*/

    }
}
