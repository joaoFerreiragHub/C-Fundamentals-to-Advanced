using System;

namespace PooExamples.AbstractExample
{
    class Panda : Animal
    {
        public override void Respirar()
        {
            Console.WriteLine("Panda a respirar");
        }

        public void SubirArvore()
        {
            Console.WriteLine("Panda a subir árvore");
        }
    }
}
