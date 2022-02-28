using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooExamples.Abstract
{
    static class MainAbstract
    {
        public static void Main()
        {
            List<Animal> animais = new List<Animal>();

            animais.Add(new Jacare());
            animais.Add(new Panda());
            animais.Add(new Jacare());
            animais.Add(new Cobra());


            foreach (var animal in animais)
            {
                animal.Anda();
            }
        }
    }
}
