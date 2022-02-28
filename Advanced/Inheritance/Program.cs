using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio myRadio = new Radio(false, "Sony");
            myRadio.SwitchOn();
            myRadio.listenRadio();

            TV myTV = new TV(false, "Samsung");
            myTV.SwitchOn();
            myTV.watchTV();
        }
    }
}
