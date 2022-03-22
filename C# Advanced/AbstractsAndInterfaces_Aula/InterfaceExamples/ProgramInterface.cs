using PooExamples.InterfaceExamples.Animais;
using PooExamples.InterfaceExamples.Interfaces;
using System.Collections.Generic;

namespace PooExamples.InterfaceExamples
{
    static class ProgramInterface
    {
        public static void MainExample()
        {
            var animais = new List<IAnimal>
            {
                new Golfinho(),
                new Gato(),
                new Cobra()
            };

            var mamiferos = new List<IMamifero>
            {
                new Golfinho(),
                new Gato(),
                // new Cobra(), ← Cobra não é um mamífero
            };

            foreach (var mamifero in mamiferos)
            {
                mamifero.GetClasse();
            }

            foreach (var animal in animais)
            {
                animal.Comer();
                animal.Dormir();
                System.Console.WriteLine("".PadLeft(20, '-'));
            }
        }
    }
}
