using InterfacesNaAula.Interfaces;
using System;

namespace InterfacesNaAula
{
    class Program
    {
        static void Main(string[] args)
        {
            IAutentica memoryAuthenticator = new MemoryAuthenticator();
            IAutentica fileAuthenticator = new FileAuthenticator();

            // true
            var ok = fileAuthenticator.Validar("admin", "123456");

            // false
            ok = memoryAuthenticator.Validar("admin", "123456");
        }
    }
}
