using System;

namespace ArraysAsParameters
{
    class Program
    {
        static void Main(string[] args)
        {
           // int[] studentGrades = new int[] { 15, 10, 8, 12, 6, 16 };
           // double averageResult = GetAverage(studentGrades);

            int[] happiness = new int[] { 10, 2, 5, 7, 9 };
            IncreaseHapiness(happiness);

           // Console.WriteLine("The average gis: {0}: ", averageResult);
          // Console.ReadKey();
            foreach(int joy in happiness)
            {
                Console.WriteLine("{0}", joy);
            }
            Console.ReadKey();
        }

        static double GetAverage(int[] gradesArray)
        {
            int size = gradesArray.Length;
            double average;
            int sum = 0;

            for (int i = 0; i < size; i++)
            {
                sum += gradesArray[i];
            }
            average = (double)sum / size;
            return average;
        }

        static void IncreaseHapiness(int [] beHappy)
        {
            int size = beHappy.Length;

            for(int i = 0; i< size; i++)
            {
                beHappy[i] += 2; 
            }  
        }
    }
}
