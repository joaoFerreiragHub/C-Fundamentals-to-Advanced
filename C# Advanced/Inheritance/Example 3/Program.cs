using System;

namespace Inheritance_Challenge_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Create a main class with the Main Method, then a base class 
             * Employee with the properties Name, FirstName, Salary, and the methods Work() and Pause().
            Create a deriving class boss with the property CompanyCar and the method Lead().  
            Create another deriving class of employees - trainees with the properties WorkingHours and SchoolHours and a method Learn().
            Override the methods Work() of the trainee class so that it indicates the working hours of the trainee.
            Don’t forget to create constructors.
             Create an object of each of the three classes (with arbitrary values)

            and call the methods, Lead() of Boss and Work() of Trainee.
            Just print out the respective text, what the respective employees do.
            E.g. Lead() should print out something like. I'm leading. It is up to you what you print out.*/



            Employee employee1 = new Employee("James", "Jerard", 1500);
            Trainees trainee1 = new Trainees("Kev", "Deux", 1000, 40, 24);
            Boss boss1 = new Boss("Trevor", "Tray", 5000, "Lambo");
            trainee1.Work();
            boss1.Lead();
          
            Console.ReadKey();
        }
    }
}
