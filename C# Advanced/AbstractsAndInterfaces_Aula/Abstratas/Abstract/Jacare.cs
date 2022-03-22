using PooExamples.Interfaceexamples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooExamples.Abstract
{
    class Jacare : Animal, IAnimal
    {
        public override void Anda()
        {
            Rasteja();
        }

        public void Comer()
        {
            Console.WriteLine("A comer");
        }

        public void Dormir()
        {
            Console.WriteLine("A dormir");
        }

        public void Rasteja()
        {
            Console.WriteLine("A rastejar");
        }
    }
}
