using System;
using System.Collections.Generic;
using System.Threading;

namespace CorridaDeCarros
{
    public class Program
    {

        static void Main(string[] args)
        {

            var ofici = new oficina();
            var teste2 = ofici.GerarCarros();
            var list = new Pista(teste2);

            while (true)
            {
                Console.Clear();
                Carro winner = null;


                while (!list.HaVencedor(teste2, 100))
                {
                    // list.quemGanhou(100, teste2);
                    list.MaisUmaVolta(teste2);
                    list.pint(teste2, 100);


                    Thread.Sleep(500);
                }

                Console.WriteLine("\n Prima qq tecla para outra corrida");
                Console.WriteLine($"O vencedor é {winner.marca}");

                Console.Read();
            }

            Console.WriteLine("Prima qq tecla para terminar");
            Console.Read();
        } 
    }
}