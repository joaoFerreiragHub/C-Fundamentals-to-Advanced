using PooExamples.InterfaceExamples.Interfaces;
using System;

namespace PooExamples.InterfaceExamples
{
    internal class MemoryAuthenticator : IAutentica
    {
        public bool Validar(string user, string password) 
            => user == "admin" && password == "admin";

        public void Sair() => Console.WriteLine("Até à próxima.");
    }
}