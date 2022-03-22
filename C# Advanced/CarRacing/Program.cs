using System;
using System.Collections.Generic;
using System.Threading;

namespace CarRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var veiculos = new Oficina().FabricarVeiculos(10);
                var pista = new Pista(100, veiculos);
                Console.Clear();

                while (!pista.HaVencedor())
                {
                    pista.MaisUmaVolta();
                    pista.Print();

                    Thread.Sleep(500);
                }

                foreach (var vencedor in pista.GetVencedores())
                    Console.WriteLine($"O vencedor é {vencedor.Marca}, {vencedor.Kms}km ");

                Console.WriteLine("Prima qq tecla para outra corrida");
                Console.Read();
            }

            Console.WriteLine("Prima qq tecla para terminar");
            Console.Read();
        }
    }
}