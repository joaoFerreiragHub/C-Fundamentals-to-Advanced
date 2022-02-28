using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Challenge_2
{
    class Trainees : Employee
    {
        public int WorkingHours { get; set; }
        public int SchoolHours { get; set; }

        public Trainees()
        {

        }

        public Trainees(string name, string firstName, int salary, int workingHours, int schoolHours)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
            this.WorkingHours = workingHours;
            this.SchoolHours = schoolHours;
        }
        public void Learn()
        {

        }

        public override void Work()
        {
            Console.WriteLine("I been working for {0} to get paid {1} and after that I still have to study {2}", WorkingHours, Salary, SchoolHours);
        }
    }
}
