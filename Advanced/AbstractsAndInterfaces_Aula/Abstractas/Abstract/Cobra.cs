using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooExamples.Abstract
{
    class Cobra : Animal
    {

        public override void Anda()
        {
            Rastejar();
        }

        public void Rastejar()
        {
            Console.WriteLine("a rastejar");
        }
    }
}
