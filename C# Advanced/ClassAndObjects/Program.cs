using System;

namespace ClassAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Human john = new Human("John", "Doe", "Green", 25);
            john.IntroduceMyself();

            Human jane = new Human("Jane", "Doe", "Blue");
            jane.IntroduceMyself();

            Human jenny = new Human("Jenny", "Doe", 12);
            jenny.IntroduceMyself();

            Human james = new Human("James", "Doe");
            james.IntroduceMyself();

            Human jeremy = new Human("Jeremy");
            jeremy.IntroduceMyself();
             
            Human jessica = new Human("Doe", 25, "Brown");
            jessica.IntroduceMyself();

            Console.ReadKey();
        }  
    } 
}
