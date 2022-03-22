using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideDemo
{
    class Animal
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public bool isHungry { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
            isHungry = true;
        }

       public virtual void MakeSound()
        {

        }
        
        public virtual void Eat()
        {
            if(isHungry)
            {
                Console.WriteLine($"{Name} time to eat!");
            }
            else
            {
                Console.WriteLine($"{Name} is full");
            }
        }
           
        public virtual void Play()
        {
            Console.WriteLine($"{Name} is playing");
        }
    }
}

