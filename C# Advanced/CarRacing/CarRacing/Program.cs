using System;
using System.Collections.Generic;
using System.Threading;

namespace CarRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamPista = 100;
            var rnd = new Random();

            // Instalar a package Bogus disponível em nuget.org
            var faker = new Bogus.Faker();
            var model = faker.Vehicle.Model();
            var manufacturer = faker.Vehicle.Manufacturer();


            Console.WriteLine(new Carro());


            Carro[] carros = new Carro[10];
            List<Carro> veiculos = new List<Carro>();

            for (int i = 0; i < 10; i++)
            {
                var colorNumber = rnd.Next(1, 16);
                veiculos.Add(new Carro(faker.Vehicle.Manufacturer(), (ConsoleColor)colorNumber));
            }


            while (true)
            {
                Console.Clear();
                Carro winner = null;

                // enquanto nenhum carro chegou ao fim da pista
                while (winner == null)
                {
                    Console.Clear();

                    foreach (var carro in veiculos)
                    {
                        carro.Move();
                        carro.Print();
                    }

                    // Verifica se algum dos carros terminou a corrida
                    //if (c1.Kms >= tamPista)
                    //    winner = c1;
                    //else if (c2.Kms >= tamPista)
                    //    winner = c2;

                    Thread.Sleep(500);
                }

                Console.WriteLine("Prima qq tecla para outra corrida");
                Console.WriteLine($"O vencedor é {winner.Marca}");

                Console.Read();
            }

            Console.WriteLine("Prima qq tecla para terminar");
            Console.Read();
        }

    }
}
