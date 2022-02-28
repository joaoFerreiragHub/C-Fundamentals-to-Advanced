using PooExamples.InterfaceExamples.Interfaces;

namespace PooExamples.InterfaceExamples
{
    public class Golfinho : IAnimal, IMamifero
    {
        public void Comer()
        {
            System.Console.WriteLine("Golfinho a comer");
        }

        public void Dormir()
        {
            System.Console.WriteLine("Golfinho a dormir");
        }

        public void GetClasse()
        {
            throw new System.NotImplementedException();
        }
    }
}