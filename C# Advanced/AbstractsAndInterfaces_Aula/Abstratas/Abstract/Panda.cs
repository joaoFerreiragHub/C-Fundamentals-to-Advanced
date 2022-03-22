using PooExamples.Interfaceexamples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooExamples.Abstract
{
    class Panda : Animal, IAnimal
    {
        public override void Anda()
        {
            SubirArvores();
        }

        public void SubirArvores()
        {
            Console.WriteLine("A trepar");
        }

        void IAnimal.Comer()
        {
            Console.WriteLine("A comer");
        }

        void IAnimal.Dormir()
        {
            Console.WriteLine("A dormir");
        }
    }
}
