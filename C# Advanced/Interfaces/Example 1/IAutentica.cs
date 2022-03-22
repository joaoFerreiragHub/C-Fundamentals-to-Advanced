using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesNaAula.Interfaces
{
    public interface IAutentica
    {
        bool Validar(string username, string password);

        void Sair();
    }
}
