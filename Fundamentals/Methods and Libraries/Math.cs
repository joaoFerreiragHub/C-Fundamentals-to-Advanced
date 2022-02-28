using System;
using Utils.Consola;


namespace Utils.Brain

{
    public  class Math
    {
        public static void NumberEvenGreaterthanZero()
        {
            Console.WriteLine("Introduza um numero: ");
            string str1 = Console.ReadLine();
            int num = int.Parse(str1);
            int res = num % 2;

            if (res == 0 && num > 0)
            {
                Console.WriteLine("É par e maior que zero");
            }
            else if (res != 0 && num > 0)
            {
                Console.WriteLine("É positivo e Impar!");

            }
            else if (res != 0 && num < 0)
            {
                Console.WriteLine("É negativo e Impar!");
            }
            else if (res == 0 && num == 0)
            {
                Console.WriteLine("Introduziu 0");
            }
            else
            {
                Console.WriteLine("O numero negativo e par");
            }

        }
        public static void SecondsToMinutes()
        {
            Console.WriteLine("Introduza o numero de segundos");
            string str1 = Console.ReadLine();
            int min = int.Parse(str1);
            int res;
            int seg;

            //seg = min % 60;
            res = min / 60;
            seg = min - (res * 60);

            Console.WriteLine("sao {0} minutos {1} segundos", res, seg);

        }

        public static int ReadInt(string mensagem)
        {
            Console.WriteLine(mensagem);
            return int.Parse(Console.ReadLine());
        }

        public static int InsertNumbers(string message)
        {
            Console.WriteLine(message);
            string strnum = Console.ReadLine();
            return int.Parse(strnum);
        }

        public static void CalculadoraSwi()
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
        public static void Calculadora()
        {
            bool temErro = false;
            int num1 = 0;
            int num2 = 0;
            int result = 0;
            string str3 = "";

            temErro = Console2.InputNumbers("Insira o 1º numero", out num1);

            if (temErro)
            {
                Console.WriteLine("Erro no num1");
                return;
            }

            temErro = Console2.InputNumbers("Introduzir 2º Numero", out num2);

            if (temErro)
            {
                Console.WriteLine("Erro no num2");
                return;
            }

            str3 = Console2.Operadores("Insira um Operador:");
            temErro = Console2.TryCompute(str3, num1, num2, out result);

            if (!temErro)
                Console.WriteLine($"{num1} {str3} {num2} = {result}");

            Console.Read();
        }

    }

}
