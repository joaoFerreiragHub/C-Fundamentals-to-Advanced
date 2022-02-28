using PooExamples.Interfaceexamples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooExamples.Abstract
{
    static class MainABbstract
    {
        public static void MainExample()
        {
            List<IAnimal> animais = new List<IAnimal>
            {
                //List<Animal> animals = new List<Animal>();
                new Jacare(),
                new Panda(),
                new Jacare(),
                new Cobra()
            };


            foreach (var animal in animais)
            {
                //animal.andar();
                animal.Comer();
                animal.Dormir();
                Console.WriteLine(" ".PadLeft(20, '-'));
            }
        }
    }
}
