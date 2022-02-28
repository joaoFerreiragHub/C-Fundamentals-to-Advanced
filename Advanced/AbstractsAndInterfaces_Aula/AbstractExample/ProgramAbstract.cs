using System.Collections.Generic;

namespace PooExamples.AbstractExample
{
    static class ProgramAbstract
    {
        public static void MainExample()
        {
            var animais = new List<Animal>
            {
                new Jacare(),
                new Panda(),
                new Jacare()
            };

            foreach (var animal in animais)
            {
                animal.Respirar();
            }
        }
    }
}
