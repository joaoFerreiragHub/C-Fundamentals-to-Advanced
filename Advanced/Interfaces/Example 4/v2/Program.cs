using System;

namespace Autentica
{
    class Program
    {
        static void Main(string[] args)
        {
            Escrever teste = new Escrever();

            teste.Ler();
            var x = teste.Registar();
            var y = teste.Registar1();
            teste.Guardar(x, y);
            

        }
    }
}
