using PooExamples.InterfaceExamples.Interfaces;

namespace PooExamples.InterfaceExamples.Animais
{
    public class Gato : IAnimal, IMamifero
    {
        public void Comer()
        {
            System.Console.WriteLine("Gato a comer");
        }

        public void Dormir()
        {
            System.Console.WriteLine("Gato a dormir");
        }

        public void GetClasse()
        {
            throw new System.NotImplementedException();
        }
    }


}