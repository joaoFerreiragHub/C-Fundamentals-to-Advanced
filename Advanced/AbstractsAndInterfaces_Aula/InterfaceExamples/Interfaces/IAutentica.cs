namespace PooExamples.InterfaceExamples.Interfaces
{
    public interface IAutentica
    {
        bool Validar(string username, string password);

        void Sair();
    }
}