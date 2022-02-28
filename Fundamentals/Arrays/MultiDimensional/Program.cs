using System;

namespace ArrayMultiDimensional
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2D array
            string[,] matrix;

            // 3D array
            int[,,] threeD;

            int[,] array2D = new int[,]
            {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };

            string[,,] array3D = new string[,,]
            {
                {
                    {"000", "001" },
                    {"000", "001" },
                    {"000", "001" }
                },
                {
                    {"000", "001" },
                    {"000", "001" },
                    {"000", "001" }
                },
            };

            // Rank returns the amaount of dimensions
            int dimensions = array3D.Rank;

            Console.WriteLine("Central value is {0}", array2D[1, 1]);
            Console.ReadKey();

        }
    }
}
