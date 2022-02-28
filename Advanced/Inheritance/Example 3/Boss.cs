using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Challenge_2
{
    class Boss : Employee
    {
        public string CompanyCar { get; set; }


        public Boss()
        {

        }
        public Boss(string name, string firstName, int salary, string companyCar)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
            this.CompanyCar = companyCar;

        }

        public void Lead()
        {
            Console.WriteLine("Im doing laps on my {0} because I'm the {1} and I get paid {2}", CompanyCar, Name, Salary);
        }
    }
}
