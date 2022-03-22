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
        string name;
        string password;

        public void Registar()
        {
            Console.WriteLine("Introduza o seu username\n");
            name = Console.ReadLine();
            Console.WriteLine("\n Introduza a sua Password");
            password = Console.ReadLine();
        }

        bool IAutentica.Validar(string username, string password)
        {
            if (File.Exists(@"C:\TugaExchange\coins.json"))
            {
                var json = File.ReadAllText(@"C:\Temp\UserDados.json");
                var json1 = File.ReadAllText(@"C:\Temp\UserDados.json1");

                name = JsonSerializer.Deserialize<string>(json);
                password = JsonSerializer.Deserialize<string>(json1);
                return true;
            }
            return false;
        }

        void IAutentica.sair()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string userNamePass = @"C:\Temp\UserDados.json";
            string json = JsonSerializer.Serialize(name, options);
            string json1 = JsonSerializer.Serialize(password, options);

            File.WriteAllText(userNamePass, json);
            File.WriteAllText(userNamePass, json1);

        }
    }
}
