using System;

namespace CarRacing
{
    internal class Carro : Veiculo 
    {
        public Carro() 
        {
        }

        public Carro(string marca, ConsoleColor cor)
        {
            this.Cor = cor;
            this.Marca = marca;
        }

        public override string ToString()
        {
            // exemplo: .....Seat (5 Km)
            var kmsPercorridos = "".PadLeft(Kms, '.');
            return $"{kmsPercorridos} {Marca} ({Kms} kms)";
        }
    }
}