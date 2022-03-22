using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int counter = 0;
            while(counter < 10)
            {
                Console.WriteLine(counter);
                counter++;
            }
            Console.Read();*/
            int counter = 0;
            string enteredText = "";
            while(enteredText.Equals(""))
            {
                Console.WriteLine("Please press enter to increase anything by one and anything else " +
                    " + enter if you want to finish counting");
                enteredText = Console.ReadLine();

                counter++;
                Console.WriteLine("Currente people count is {0}", counter);
            }
            Console.WriteLine("{0} People inside the bus press enter to exit", counter);
            Console.Read();
        }
    }
}
