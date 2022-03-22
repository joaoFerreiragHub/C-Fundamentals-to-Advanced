using System;

namespace Recursions
{
    class Program
    {
        static void Main(string[] args)
        {
            float answer = 0;
            answer = Power(3 ,3);

            Console.WriteLine(answer);
        }

        private static float Power(float num , int powerOf)
        {
            if (powerOf == 1)
                return num;
            Console.WriteLine(num + " " + powerOf);
            return num * Power(num, powerOf - 1);
           /*
            3*Power(3,2)
            3*3*Power(3,1)
            3*3*3*Power(3,0)
            3*3*3*1
            */

        }
    }
}
