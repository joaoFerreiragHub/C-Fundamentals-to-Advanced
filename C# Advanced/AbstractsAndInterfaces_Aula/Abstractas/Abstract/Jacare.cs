using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooExamples.Abstract
{
    class Jacare : Animal
    {
        public override void Anda()
        {
            Rasteja();
        }

        public void Rasteja()
        {
            Console.WriteLine("A rastejar");
        }
    }
}
