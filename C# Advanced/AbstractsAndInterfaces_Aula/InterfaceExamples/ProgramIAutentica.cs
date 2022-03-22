using PooExamples.InterfaceExamples.Interfaces;
using System;
using System.Collections.Generic;

namespace PooExamples.InterfaceExamples
{
    internal static class ProgramIAutentica
    {
        public static void MainExample()
        {
            var authenticators = new List<IAutentica>()
            {
                new FileAuthenticator(),
                new MemoryAuthenticator()
            };

            foreach (var authenticator in authenticators)
            {
                Console.WriteLine($"Autenticando com {authenticator.GetType()}");
                
                var vaultService = new VaultService(authenticator);
                var key = vaultService.GetCryptoKey("admin", "123456");

                if (!string.IsNullOrWhiteSpace(key))
                    Console.WriteLine("Key: {0}", key);
                else
                    Console.WriteLine("User não está autenticado");
            }

            Console.WriteLine("End authentications");

            // true
            //var ok = fileAuthenticator.Validar("admin", "123456");

            //// false
            //ok = memoryAuthenticator.Validar("admin", "123456");
        }


    }


}