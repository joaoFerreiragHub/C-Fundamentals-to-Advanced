using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Autentica
{
    class Escrever : IAutentica
    {
        string Name;
        string Password;

        public Escrever()
        {

        }
        public Escrever(string name, string password)
        {
            this.Name = name;
            this.Password = password;
        }

        public string Registar()
        {
            Console.WriteLine("Introduza o seu username\n");
            Name = Console.ReadLine();
            return Name;
        }
        public string Registar1()
        {
            Console.WriteLine("\n Introduza a sua Password");
            Password = Console.ReadLine();
            return Password;
        }
        public string Ler()
        {
            if (File.Exists(@"C:\TugaExchange\UserDados.json")&&
                File.Exists(@"C:\TugaExchange\UserDados1.json"))
            {
                var json = File.ReadAllText(@"C:\TugaExchange\UserDados.json");
                var json1 = File.ReadAllText(@"C:\TugaExchange\UserDados1.json");

                Name = JsonSerializer.Deserialize<string>(json);
                Password = JsonSerializer.Deserialize<string>(json1);
                return Name;
            }
            return null;
        }

        public void Guardar(string name, string password)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string userNamePass = @"C:\TugaExchange\UserDados.json";
            string userNamePass1 = @"C:\TugaExchange\UserDados1.json";

            string json = JsonSerializer.Serialize(Name, options);
            string json1 = JsonSerializer.Serialize(Password, options);

            File.WriteAllText(userNamePass, json);
            File.WriteAllText(userNamePass1, json1);

        }
        bool IAutentica.Validar(string username, string password)
        {
            if (Ler() == username))
                return true;
            else
                return false;
        }

        void IAutentica.sair()
        {


        }
    }
}
