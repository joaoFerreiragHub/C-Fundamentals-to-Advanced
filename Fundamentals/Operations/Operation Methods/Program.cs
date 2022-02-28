using System;

namespace MethodsValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(Add(1, 2), Add(3, 4))); 
            Console.WriteLine(Add(15,31));
            Console.WriteLine(Multiply(5,6));
            Console.WriteLine(Divison(3,3));
        }

        public static int Add(int num1,int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Divison(double num1, double num2)
        {
            return num1 / num2;
        }

    }
}
