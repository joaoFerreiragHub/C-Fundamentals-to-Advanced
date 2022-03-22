using PooExamples.InterfaceExamples.Interfaces;
using System;

namespace PooExamples.InterfaceExamples
{
    public class VaultService
    {
        private IAutentica _authenticator;

        public VaultService(IAutentica authenticator)
        {
            _authenticator = authenticator;
        }

        public string GetCryptoKey(string username, string password)
        {
            return _authenticator.Validar(username, password)
                ? Guid.NewGuid().ToString()
                : null;
        }
    }
}