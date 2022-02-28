using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjects
{
    class Human
    {   
        // Member variable
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;

        //Default constructor
        public Human()
        {
            Console.WriteLine("Constructor Called. Object created");
        }
        public Human(string firstName)
        {
            this.firstName = firstName;
        }

        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Human(string lastName, int age, string eyeColor)
        {
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        public Human(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }
        public Human(string firstName, string lastName, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }

        //parameterized Constructor
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        // Member Method
        public void IntroduceMyself()
        {
            if (age != 0 && lastName != null && eyeColor != null && firstName != null)
                Console.WriteLine("Hi, I'm {0} {1} and {2} years old. My eye color is {3}", firstName, lastName, age, eyeColor);
            else if (age != 0 && lastName != null && firstName != null)
            {
                Console.WriteLine("Hi, I'm {0} {1} and {2} years old.", firstName, lastName, age);
            }
            else if (eyeColor != null && lastName != null && firstName != null)
            {
                Console.WriteLine("Hi, I'm {0} {1} and my eye color is {2}", firstName, lastName, eyeColor);
            }
            else if (eyeColor != null && lastName != null && age != 0)
            {
                Console.WriteLine("Hi, my last name is {0} I'm {1} years old. My eye color is {2}", lastName, age, eyeColor);
            }
            else if (lastName != null && firstName != null)
            {
                Console.WriteLine("Hi, I'm {0} {1}.", firstName, lastName);
            }
            else if (firstName != null)
            {
                Console.WriteLine("Hi, I'm {0} ", firstName);
            }

        }
    }
}

