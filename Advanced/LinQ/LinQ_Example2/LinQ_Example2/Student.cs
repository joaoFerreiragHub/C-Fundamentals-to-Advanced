using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_Example2
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        //foreign key

        public int universityId { get; set; }

        public void Print()
        {
            Console.WriteLine("Stundet {0} with Id {1}, Gender {2} and Age {3} " +
                "from university with Id {4}", Name, Id, Gender, Age, universityId
                );
        }
    }
}
