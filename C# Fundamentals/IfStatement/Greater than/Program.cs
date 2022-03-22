using System;

namespace VerificarMaior
{
    class Program
    {
        static void BiggerNumber()
        {
          
                Console.WriteLine("Insira 1º Numero");
                string stnum1 = Console.ReadLine();
                // int num1 = int.Parse(stnum1); 
                int num1;
                bool success = int.TryParse(stnum1, out num1);

                if (success)
                {
                    Console.WriteLine(num1);
                }
                else
                {
                    Console.WriteLine("Incorrect value entered.");
                }
            
                Console.WriteLine("Insira 2º Numero");
                string stnum2 = Console.ReadLine();
                //int num2 = int.Parse(stnum2);
                int num2;
                bool success2 = Int32.TryParse(stnum2, out num2);

                if (success2)
                {
                    Console.WriteLine(num2);
                }
                else
                {
                    Console.WriteLine("Incorrect value entered.");
                }


                if (num1 > num2)
                {
                    Console.WriteLine("o maior numero é {0}", num1);
                }
                else if (num1 == num2)
                {
                    Console.WriteLine("São iguais");
                }
                else
                {
                    Console.WriteLine("o maior numero é {0}", num2);
                }

            

            Console.WriteLine("Comparação bem sucedida");
        }


        static void Main(string[] args)
        {
            BiggerNumber();
            //swapNumbers();
            //calcularfatorial();
            //calcularfatorialamao();
            Console.Read();
        }

        static void swapNumbers()
        {
            Console.WriteLine("Function to swap values");
            Console.WriteLine("Insira o numero 1:");
            string stnum1 = Console.ReadLine();
            int num1 = int.Parse(stnum1);

            Console.WriteLine("Insira o numero 1:");
            string stnum2 = Console.ReadLine();
            int num2 = int.Parse(stnum2);

            if (num1 == num2)
            {
                Console.WriteLine("Os numeros sao iguais");
            }
            else
            {
                int var = num1;
                num1 = num2;
                num2 = var;
            }

            Console.WriteLine("O 1º valor agora é {0} e o segundo valor é {1}", num1, num2);

        }

        static void calcularfatorial()
        {
            Console.WriteLine("Insira um numero:");
            string stnum1 = Console.ReadLine();
            int num1 = int.Parse(stnum1);
            int i;
            int fact = 1;

            for (i = 1; i <= num1; i++)
            {
                fact = fact * i;
            }

            Console.WriteLine("O resultado do factorial é {0}:", fact);
        }

        static void calcularfatorialamao()
        {
            Console.WriteLine("Insira um numero:");
            string stnum1 = Console.ReadLine();
            int num1 = int.Parse(stnum1);
            

            if(num1 == 5)
            {
                num1 = 5 * 4 * 3 * 2 * 1;
            }
            else if(num1 == 4)
            {
                num1 = 4 * 3 * 2 * 1;
            }
            else if (num1 == 3)
            {
                num1 = 3 * 2 * 1;
            }
            else if (num1 == 2)
            {
                num1 = 2 * 1;
            }
            else if (num1 == 1)
            {
                num1 = 1;
            }
            else
            {
                Console.WriteLine("Introduza um numero entre 1 e 5");
            }
        }
    }

        
    
}
