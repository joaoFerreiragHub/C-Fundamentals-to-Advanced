using System;
using System.Collections.Generic;

namespace PolymorfismoParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>
            {
                new Audi (200, " BLue", "A4"),
                new BMW (250, "Red", "R3")

            };

            foreach (var car in cars)
            {
                car.Repair();
            }

            Car bmwZ3 = new BMW(200, " Black", "Z3");
            Car AudiA3 = new BMW(100, " Green", "A3");
            bmwZ3.ShowDetails();
            bmwZ3.SetCardIDInfo(1234, "Denis");
            AudiA3.ShowDetails();
            bmwZ3.GetCarIDInfo();

            BMW bmwM5 = new BMW(330, "White", "M5");
            bmwM5.ShowDetails();

            Car carB = (Car)bmwM5;
            carB.ShowDetails();

            M3 myM3 = new M3(260, "red", " M3 Super Turbo");
            myM3.Repair();

            Console.ReadKey();
        }
    }
}
