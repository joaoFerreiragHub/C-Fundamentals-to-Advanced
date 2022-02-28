using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreasureHunt.Interface;

namespace TreasureHunt
{
    public abstract class Vehicle 
    {
        public char Nome { get; set; }

        public Vehicle()
        {

        }
        public abstract void Move();

    }
}
