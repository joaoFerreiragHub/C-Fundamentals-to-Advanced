using System;

namespace CollectionsArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Version 1 initializing array
            int[] grades = new int[5];

            grades[0] = 20;
            grades[1] = 15;
            grades[2] = 12;
            grades[3] = 9;
            grades[4] = 7;

            Console.WriteLine("Grades at index 0 : {0}", grades[0]);

            string input = Console.ReadLine();
            grades[0] = int.Parse(input);

            Console.WriteLine("Grades at index 0 : {0}", grades[0]);
            

            // Version 2 initializing array
            int[] gradesOfMathStudentsA = { 20, 12, 12, 0, 0 };

            // Version 3 initializing array
            int[] gradesOfMathStudentsb = new int[] { 20, 11, 10, 5, 3 };

            Console.WriteLine("Lenght of gradesOfMathStudentsA {0}", gradesOfMathStudentsA.Length);
            Console.ReadKey();

            */
            /*
            int[] nums = new int[10];

            for (int i = 1; i < 10; i++)
            {
                nums[i] = i;
            }

            for (int j = 1; j < 10; j++)
            {
                Console.WriteLine("Element {0} = {1}", j, nums[j]);
            }*/
            int[] nums = new int[] { 20, 11, 10, 5, 3 };

            int counter = 0;
            foreach (int k in nums)
            {
                Console.WriteLine("Element {0} = {1}", counter, k);
                counter++;
                
            }

            
            /*
            string[] friends = new string[] { "Jessy", "James", "Jeremy", "Jane", "Jimmy" };

          
            foreach(string f in friends)
            {
                Console.WriteLine("Hello {0}!", f);
                
            }
            */

            Console.ReadKey();
        }
    }
}
