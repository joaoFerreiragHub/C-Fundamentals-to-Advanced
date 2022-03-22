using System;

namespace Arraysdaaula
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5] { 1, 3, 5, 7, 9 };

            Console.WriteLine(numeros[2]);

            //incrementa
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = i+1;
                Console.WriteLine(numeros[i]);
               

            }
            Console.WriteLine(numeros[2]);
            //descrescente 
            /* for (int i = numeros.Length -1 ; i >= 0; i--)
             {    
                 Console.WriteLine(numeros[i]);

             }*/

            /* int soma = 0;
             for (int i = 0; i < numeros.Length; i++)
             {


                 soma += numeros[i];
                 Console.WriteLine($" {soma - numeros[i]} + {numeros[i]} = {soma}");
             }

             Console.WriteLine(soma);*/
            Console.Read();
        }
    }
}





