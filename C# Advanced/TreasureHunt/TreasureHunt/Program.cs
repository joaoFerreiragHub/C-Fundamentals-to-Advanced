using System;
using TreasureHunt.Interface;

namespace TreasureHunt
{
    class Program
    {
        static void Main(string[] args)
        {
            IElement novoMapa = new Forest();
            novoMapa.Print();
        }
    }
}
