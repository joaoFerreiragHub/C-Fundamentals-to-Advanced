using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class ElectricalDevice
    {
        //Properties
        public bool IsOn { get; set; }

        public string Brand { get; set; }

        // Constructor
        public ElectricalDevice(bool isOn, string brand)
        {
            this.IsOn = isOn;
            this.Brand = brand;
        }

        // methods
        public void SwitchOn()
        {
            IsOn = true;
        }

        public void SwitchOff()
        {
            IsOn = false;
        }
    }
}
