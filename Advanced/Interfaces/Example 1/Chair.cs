using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Chair : Furniture
    {
        public Chair(string color, string material)
        {
            this.Color = color;
            this.Material = material;
        }
    }
}
