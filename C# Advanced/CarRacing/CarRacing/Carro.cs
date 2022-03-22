using System;

namespace CarRacing
{
    internal class Carro
    {
        
        public ConsoleColor Cor { get; set; }
        public string Marca { get; set; }
        public int Kms { get; set; }

        private int _numPortas;
        public int NumPortas { get => _numPortas; set => _numPortas = value; }

        private static int NumCarros = 0;
        Random rnd = new Random();

        public Carro()
        {
            NumCarros++;
        }

        public static int GetNumCarros()
        {
            return NumCarros;
        }

        public static void Hello()
        {
            Console.WriteLine("Hello");
        }

        public Carro(string marca, ConsoleColor cor)
        {
            this.Cor = cor;
            this.Marca = marca;

            NumCarros++;
        }

        public void Print()
        {
            // ...Seat (3km)

            Console.ForegroundColor = Cor;

            for (int i = 0; i < Kms; i++)
                Console.Write(".");

            Console.WriteLine($"{Marca} ({Kms} kms)");
            Console.ResetColor();
        }

        /// <summary>
        /// Faz o veículo "andar" um determinado n.º de kms
        /// </summary>
        internal void Move()
        {
            var kmsPercorridos = rnd.Next(1, 10);
            Kms += kmsPercorridos;
        }

    }
}
