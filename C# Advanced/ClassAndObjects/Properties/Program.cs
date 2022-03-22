using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Box daBox = new Box(3,4,5);
            //daBox.lenght = 3;
            //daBox.setLength(4);
            //daBox.Height = 4; 
            //daBox.Width = 5;

            Console.WriteLine("Box lenght is: {0}", daBox.GetLength());
            daBox.Width = 10;
            Console.WriteLine("Front surface of the box is: {0}", daBox.FrontSurface);
            Console.WriteLine("Box Volume is: {0}", daBox.Width);
            Console.WriteLine("Box Volume is: {0}", daBox.Volume);
            daBox.DisplayInfo();

        }
    }
}
