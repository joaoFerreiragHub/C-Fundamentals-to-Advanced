using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorfismoParameters
{
    class Car
    {
        public int HP { get; set; }
        public string  Color { get; set; }


        protected CarIDInfo carIDInfo = new CarIDInfo();

        public void SetCardIDInfo(int Idnum, string owner)
        {
            carIDInfo.IDnum = Idnum;
            carIDInfo.Owner = owner;

        }

        public void GetCarIDInfo()
        {
            Console.WriteLine("The car has the ID of {0} and is owned by {1}", carIDInfo.IDnum, carIDInfo.Owner);
        }

        public Car()
        {

        }

        public Car(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        }

        public virtual void ShowDetails()
        {
            Console.WriteLine("HP: " + HP + " color:" + Color);
        }

        public virtual void Repair()
        {
            Console.WriteLine("Car was repaired");
        }
    }
}
