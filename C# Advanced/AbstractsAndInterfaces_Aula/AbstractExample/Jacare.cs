using System;

namespace PooExamples.AbstractExample
{
    class Jacare : Animal
    {

        public override void Respirar()
        {
            Console.WriteLine("Jacare a respirar");
        }

        public void Rastejar()
        {
            Console.WriteLine("Jacaré a rastejar");
        }
    }
}
