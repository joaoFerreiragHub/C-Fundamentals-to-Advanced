using System;

namespace NestedArrays
{
    class Program
    {


        static int[,] matrix =
        {
            {1,2,3},// 00, 01, 02
            {4,5,6},// 10, 11, 12
            {7,8,9} // 20, 21, 22
        };

        static void Main(string[] args)
        {

            for (int i = 0, j = 2; i < matrix.GetLength(0); i++, j--)
            {
                Console.WriteLine(matrix[i,j]);
            }


            
        }
    }
}


/*
 * for (int i = 0; i < matrix.GetLength(0); i++)
{
    Console.WriteLine(matrix[i,i]);  // 00,11,22
}



foreach(int item in matrix)
{
    Console.Write(item + " ");
}

Console.WriteLine("\n This is our 2D array printed using nested for loop");

//Outer for loop
for(int i = 0; i < matrix.GetLength(0); i++)
{
    //inner for loop
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if(i == j)
        {
            Console.Write(matrix[i, j] + " ");
        }
        else
        {
            Console.WriteLine(" ");
        }
    }
    Console.WriteLine("");*/