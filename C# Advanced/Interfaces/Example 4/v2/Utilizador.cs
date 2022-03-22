using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autentica
{
    class Utilizador : IAutentica
    {

        public bool Validar(string user, string password)
        {
            return true;
        }

        public void sair()
        {
            throw new NotImplementedException();
        }

    }
}
