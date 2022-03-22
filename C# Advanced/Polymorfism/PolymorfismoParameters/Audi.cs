using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorfismoParameters
{
    class Audi: Car
    {
        public string Brand = "Audi";
        public string Model { get; set; }

        public Audi(int hp, string color, string model) : base(hp, color)
        {
            this.Model = model;
        }

        public new void ShowDetails()
        {
            Console.WriteLine("Brand " + Brand + " HP:" + HP + " color:" + Color);
        }

        public override void Repair()
        {
            Console.WriteLine("The Audi {0} was repaired", Model);
        }
    }
}
