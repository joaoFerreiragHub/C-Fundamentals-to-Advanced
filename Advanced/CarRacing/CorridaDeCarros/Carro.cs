using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorridaDeCarros
{
   public class Carro
    {
        public Random rng = new Random();
        public String marca { get; set; }
        public int km { get; set; }
        public ConsoleColor cor { get; set; }


        public Carro()
        {
        }
        public Carro(string marca, ConsoleColor color)
        {
            this.marca = marca;
            this.cor = color;
        }
        public void print()
        {
            Console.ForegroundColor = cor;
            var contorno = "".PadRight(km, '-');
            Console.Write(contorno);
            Console.WriteLine($"{marca} ({km})Kms");
            Console.ResetColor();

        }
        public void Mover()
        {
            km += rng.Next(1,10);
        }

    }
}
