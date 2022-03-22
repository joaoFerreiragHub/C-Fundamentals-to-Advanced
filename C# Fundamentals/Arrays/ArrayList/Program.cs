﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace ArrayListProjec
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring an ArrayList with undefined amount of object
            ArrayList myArrayList = new ArrayList();

            //declaring an ArrayList with defined amount of object
            ArrayList myArrayList2 = new ArrayList(100);

            myArrayList.Add(25);
            myArrayList.Add("Hello");
            myArrayList.Add(13.37);
            myArrayList.Add(10);
            myArrayList.Add(25.3);
            myArrayList.Add(128);
            myArrayList.Add(13.37);

            // delete element with specific value from the arraylist
            myArrayList.Remove(13.37);

            // delete element with specific position from the arraylist
            myArrayList.RemoveAt(0);

            Console.WriteLine(myArrayList.Count);

            double sum = 0;

            foreach(object obj in myArrayList)
            {
                if(obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }
                else if (obj is string)
                {
                    sum += (double)(obj);
                }
                else if(obj is string)
                {
                    Console.WriteLine(obj);
                }
                Console.WriteLine(sum);
                Console.ReadKey();
            }

        }
    }
}
