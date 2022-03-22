using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooExamples.Abstract
{
    class Panda : Animal
    {
        public override void Anda()
        {
            SubirArvores();
        }

        public void SubirArvores()
        {
            Console.WriteLine("A trepar");
        }
    }
}
