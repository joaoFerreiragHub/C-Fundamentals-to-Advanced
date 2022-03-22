using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number!");
            string userInput = Console.ReadLine();

            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (FormatException)
            {
                Console.WriteLine("Format Exeception!");
                
            }
            catch(OverflowException)
            {
                Console.WriteLine("Overflow Exception");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ArgumentNullException");
            }
            finally
            {
                Console.WriteLine("This is called anyways!");
            }


        }
    }
}
