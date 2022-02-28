using System;

namespace NumerosFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            GetNthFibonacci_Ite(2);


        }

        /*public static void PrintFibonacci(int num)
        {

            int n = 1;
            int n1 = 1;
            for (int i= 1; i<num +1; i++)
            {
                int fib = n;
                 n = n1;
                 n1 = fib + n;
                 Console.WriteLine(fib);
            }        
            
        }*/

        public static int[] GetNthFibonacci_Ite(int num)
        {
            int[] fib = new int[num];
            fib[1] = 1;

            for (int i = 2; i < fib.Length; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }          
    
            foreach (var item in fib)
            {
                Console.Write(item.ToString() + "\n");
            }
            return fib;

        }
    }
}

//1+1+2+3+5
