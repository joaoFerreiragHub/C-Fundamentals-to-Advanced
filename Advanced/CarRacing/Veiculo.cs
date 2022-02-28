using System;

namespace CarRacing
{
    class Veiculo
    {
        Random rnd = new Random();
        public ConsoleColor Cor { get; set; }
        public string Marca { get; set; }
        public int Kms { get; set; }

        public Veiculo()
        {

        }

        public Veiculo(int kms)
        {

            Console.WriteLine($"A construir um veículo com {kms} kms");
        }

        public void Print()
        {
            Console.ForegroundColor = Cor;

            Console.WriteLine(this.ToString());

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