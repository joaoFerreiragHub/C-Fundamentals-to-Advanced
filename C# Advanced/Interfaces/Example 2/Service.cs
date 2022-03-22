using InterfacesNaAula.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesNaAula
{
   public  class VaultService
    {   //v1                        // _authenticcator é o meu user
        /* private IAutentica  _authenticcator = new FileAuthenticator();

         public VaultService()
         {
             _authenticcator = new FileAuthenticator();

         }
        */

        private IAutentica _authenticcator = new FileAuthenticator();

        public VaultService(IAutentica authenticator)
        {
            _authenticcator =  authenticator;

        }

        // V1
        /*public string GetCryptoKey(string username, string password)
        {
            FileAuthenticator user = new FileAuthenticator();
            if (user.Validar(username, password) == true)
                return Guid.NewGuid().ToString();
            else
                return null;
        }*/

        //v1.2 

        public string GetCryptoKey1(string username, string password)
        {
            IAutentica _authenticcator = new FileAuthenticator();
            return _authenticcator.Validar(username, password)
                 ? Guid.NewGuid().ToString()
                 : null;
         
        }
    }
}
