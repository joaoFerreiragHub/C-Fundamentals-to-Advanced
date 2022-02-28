using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalizersAndDestructors
{
    class Members
    {
        // member - private field
        private string memberName;
        private string jobTitle;
        private int salary;

        //member -  public field
        public int age;

        // member - property - exposes jobTitle safely - Properties start with Capital letter
        public string JobTitle 
        {
            get
            { 
                return jobTitle; 
            }

            set 
            { 
                jobTitle = value; 
            } 
        }

        // public member Method - can be called from other class

        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfor();
            }
            else
            {
                Console.WriteLine("Hi, my name is {0} and my job title is {1}. I'm {2} years old", memberName, jobTitle, age);
            }
            
        }

        private void SharingPrivateInfor()
        {
            Console.WriteLine("My salary is {0}", salary);
        }


        //memeber constructor
        public Members()
        {
            age = 30;
            memberName = "Lucy";
            salary = 60000;
            jobTitle = "Developer";
            Console.WriteLine("Object created");
        }


        //member - finalizer -destructor

        ~Members()
        {
            //CLEANUP STATMENTS
            Console.WriteLine("Deconstruction of Members");
        }   
    }
}
