using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class TV : ElectricalDevice
    {
        public TV(bool isOn, string brand): base (isOn, brand)
        {

        }

        public void watchTV()
        {
            if (IsOn)
            {
                Console.WriteLine("Listening to the Radio");
            }
            else
            {
                Console.WriteLine("Radio is switched off, switch it on first");
            }
        }
    }
}
