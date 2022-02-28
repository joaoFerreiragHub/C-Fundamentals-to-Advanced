using System;

namespace Calculator
{
    class CalculadoraSwitch
    {
        public static void Main(string[] args)
        {
            Calculadora();
            Console.Read();
        }

       public static void Calculadora()
        {
            bool temErro = false;
            int num1 = 0;
            int num2 = 0;

            Console.WriteLine("Insira o 1º numero");
            string str1 = Console.ReadLine();
            bool success = int.TryParse(str1, out num1);

            if (success)
            {
                Console.WriteLine("Numero Introduzido com sucesso!");

            }
            else
            {
                Console.WriteLine("Introduziu letras! Recomece");
                temErro = true;
                Environment.Exit(0);

            }

            Console.WriteLine("                       ");
            Console.WriteLine("Insira o Operador");
            Console.WriteLine("***********************");

            string str3 = Console.ReadLine();
            Console.WriteLine("Insira o 2º numero");
            string str2 = Console.ReadLine();
            bool success2 = int.TryParse(str2, out num2);
            Console.WriteLine("                       ");
            int result = 0;

            if (success2)
            {
                Console.WriteLine("Numero Introduzido com sucesso!");

            }
            else
            {
                Console.WriteLine("Introduziu letras!");
                temErro = true;

            }

            switch (str3)
            {
                case "+":
                    result = num1 + num2;
                    break;

                case "-":
                    result = num1 - num2;
                    break;

                case "*":
                    result = num1 * num2;
                    break;

                case "/":

                    if (num2 == 0)
                    {
                        Console.WriteLine("Não pode dividir por 0! Prima qualquer tecla para fechar!");
                        temErro = true;
                        Console.Read();
                        break;
                    }
                    else
                    {
                        result = num1 / num2;
                        break;
                    }


                case "%":
                    result = num1 % num2;
                    break;

                default:
                    temErro = true;
                    Console.WriteLine("erro na introdução, recomece");
                    break;

            }
            if (!temErro)

                Console.WriteLine($"{num1} {str3} {num2} = {result}");
        }

    }
}
