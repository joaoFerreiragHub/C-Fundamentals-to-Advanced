using InterfacesNaAula.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesNaAula
{
    class MemoryAuthenticator : IAutentica
    {
        public bool Validar(string user, string password)
        {
            if (user == "admin" && password == "admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Sair()
        {
            Console.WriteLine("Até à próxima.");
        }
    }
}

