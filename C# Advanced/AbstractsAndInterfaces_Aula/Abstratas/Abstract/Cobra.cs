using PooExamples.Interfaceexamples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooExamples.Abstract
{
    class Cobra : Animal, IAnimal
    {

        public override void Anda()
        {
            Rastejar();
        }

        public void Rastejar()
        {
            Console.WriteLine("a rastejar");
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
