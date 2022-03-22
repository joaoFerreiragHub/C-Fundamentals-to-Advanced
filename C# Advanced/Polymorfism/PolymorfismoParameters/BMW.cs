using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorfismoParameters
{
    class BMW : Car
    {
        public string Brand = "BMW";
        public string Model { get; set; }

        public BMW()
        {

        }
        public BMW(int hp, string color, string model):base(hp,color)
        {
            this.Model = model;
        }

        public new void ShowDetails()
        {
            Console.WriteLine("Brand " + Brand + " HP:" +  HP + " color:" + Color);
        }

        public sealed override void Repair()
        {
            Console.WriteLine("The BMW {0} was repaired", Model);
        }
    }
}
