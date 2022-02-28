using PooExamples.InterfaceExamples.Interfaces;
using System;
using System.IO;

namespace PooExamples.InterfaceExamples
{
    internal class FileAuthenticator : IAutentica
    {
        private string _fileName = "credentials.json";
        private Credentials _credentials;

        public FileAuthenticator()
        {
            if (!File.Exists(_fileName))
                SaveCredentials();

            ReadCredentials();
        }

        public bool Validar(string username, string password)
                => username == _credentials.Username && password == _credentials.Password;

        public void Sair() => Console.WriteLine("Autenticação forte..");

        private void ReadCredentials()
        {
            var json = File.ReadAllText(_fileName);
            _credentials = System.Text.Json.JsonSerializer.Deserialize<Credentials>(json);
        }

        private void SaveCredentials()
        {
            var credentials = new Credentials("admin", "123456");

            var json = System.Text.Json.JsonSerializer.Serialize(credentials);
            File.WriteAllText(_fileName, json);
        }
    }
}