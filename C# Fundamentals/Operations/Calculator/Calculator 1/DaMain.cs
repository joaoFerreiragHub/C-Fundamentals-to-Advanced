using System;
using Utils.Brain;
using Utils.Consola;


namespace Utils
{
    class DaMain
    {
        static void Main(string[] args)
        {
            Brain.Math.Calculadora();
            Brain.Math.CalculadoraSwi();
            Brain.Math.SecondsToMinutes();
            Brain.Math.NumberEvenGreaterthanZero();


            int n = 1;
            int n2 = 1;
            int tab = 7;

            while (n <= 10)
            {
               
                n2 = tab * n;
                Console.WriteLine($"{n}*{tab} = {n2}");
                n++;
            }
            Console.Read();


            int n3 = 1;
            int tab8 = 8;

            while (n3<=10)
            { 
                Console.WriteLine($"{tab8}*{n3} = {tab8 * n3}");
                n3 = n3 + 1;
            }
           
        }


    }
}

