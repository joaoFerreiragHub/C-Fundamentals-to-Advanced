using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3_SOLID
{
    public class Employee
    {
        public int Id { get; private set; }
        public string Name { get; set; }

        public Employee(string name)
        {
            Name = name;
        }

        public decimal GrossSalary { get; set; }
        public int Age { get; set; }


    }
}
