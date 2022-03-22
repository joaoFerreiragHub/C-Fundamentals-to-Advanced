using System;

namespace DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //int counter = 0;
            int lenghtOfText = 0;
            string wholeText = "";

            do
            {
                Console.WriteLine("Please enter the name of a friend");
                string nameOfFriend = Console.ReadLine();
                int currentLenght = nameOfFriend.Length;
                lenghtOfText += currentLenght;
                wholeText += nameOfFriend + " ";

                //Console.WriteLine(counter);
                //counter++;
            } while (lenghtOfText < 20);
            Console.WriteLine("Thanks, that was enough {0}!", wholeText);
            Console.Read();
        }
    }
}
