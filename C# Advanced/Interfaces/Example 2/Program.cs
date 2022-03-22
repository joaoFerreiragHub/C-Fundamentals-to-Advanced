using InterfacesNaAula.Interfaces;
using System;
using System.Collections.Generic;

namespace InterfacesNaAula
{
    class Program
    {
        static void Main(string[] args)
        {/*
            IAutentica memoryAuthenticator = new MemoryAuthenticator();
            IAutentica fileAuthenticator = new FileAuthenticator();
            
            // true
            var ok = fileAuthenticator.Validar("admin", "123456");

            // false
            ok = memoryAuthenticator.Validar("admin", "123456");

            VaultService novo = new VaultService(fileAuthenticator);
            novo.GetCryptoKey1("Jon", "123");

            VaultService novo1 = new VaultService(memoryAuthenticator);
            novo.GetCryptoKey1("Jon", "123");
            */


            var authenticators = new List<IAutentica>()
            {
                new FileAuthenticator(),
                new MemoryAuthenticator()
            };

            foreach (var authenticator in authenticators)
            {
                Console.WriteLine($"Autenticado com {authenticator.GetType().ToString()}");

                var vaultService = new VaultService(authenticator);
                var key = vaultService.GetCryptoKey1("admin", "123456");

                if (!string.IsNullOrWhiteSpace(key))
                    Console.WriteLine("Key: {0}", key);
                else
                    Console.WriteLine("User não está autenticado");
            }

            Console.WriteLine("End authentication");
        }
    }
}
