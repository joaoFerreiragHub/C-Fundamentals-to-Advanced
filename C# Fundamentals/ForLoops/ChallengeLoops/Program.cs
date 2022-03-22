using System;

namespace ChallengeLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "0";
            int count = 0;
            int notas = 0;
            int final = 0;
            

            while(input != "-1")
            {
                Console.WriteLine("Introduza uma nota: ");
                Console.WriteLine("Ja introduziu: {0}", count);

                input = Console.ReadLine();
                if(input.Equals("-1"))
                {                   
                    double avg = (double)final / (double)count;
                    Console.WriteLine(" O resultado da Média é: {0}", avg);
                }
                if (int.TryParse(input, out notas) && notas > 0 && notas < 21)
                {
                    final += notas;
                    
                }
                else 
                {
                    if (!(input.Equals("-1")))
                    {
                        Console.WriteLine("Introduza um valor entre 0 e 20");
                        continue;
                    }
                        
                }

                count++;

            }Console.Read();
        }
    }
}
