using System;
using System.Collections.Generic;

namespace CarRacing
{
    class Oficina
    {
        static Random rnd = new Random();
        static Bogus.Faker faker = new Bogus.Faker();

        public List<Veiculo> FabricarVeiculos(int numVeiculos)
        {
            var veiculos = new List<Veiculo>();

            for (int i = 0; i < numVeiculos; i++)
            {
                if (rnd.NextDouble() < 0.5)
                    veiculos.Add(CreateMoto());
                else
                    veiculos.Add(CreateCarro());
            }

            return veiculos;
        }

        static Carro CreateCarro()
        {
            var colorNumber = rnd.Next(1, 16);
            return new Carro(faker.Vehicle.Manufacturer(), (ConsoleColor)colorNumber);
        }

        private Moto CreateMoto()
        {
            var colorNumber = rnd.Next(1, 16);
            return new Moto(faker.Vehicle.Manufacturer(), (ConsoleColor)colorNumber);
        }

        public List<Carro> FabricarCarros(int numCarros)
        {
            List<Carro> veiculos = new List<Carro>();
          

            for (int i = 1; i <= 10; i++)
            {
                var colorNumber = rnd.Next(1, 16);
                veiculos.Add(new Carro(faker.Vehicle.Manufacturer(), (ConsoleColor)colorNumber));
            }

            return veiculos;
        }
    }
}