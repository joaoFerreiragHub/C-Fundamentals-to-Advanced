using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreasureHunt.Interface;

namespace TreasureHunt
{
    class Tank : Vehicle, IElement
    {
        public Tank()
        {

        }

        public Tank(char nome)
        {
            this.Nome = nome;
        }

        public void Color()
        {
            throw new NotImplementedException();
        }

        public override void Move()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            throw new NotImplementedException();
        }

        public void Simbol()
        {
            throw new NotImplementedException();
        }
    }
}
