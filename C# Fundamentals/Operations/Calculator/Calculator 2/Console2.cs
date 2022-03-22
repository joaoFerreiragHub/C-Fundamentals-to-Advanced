using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils.Consola
{
    public class Console2
    {
        public static bool InputNumbers(string message, out int result)
        {
            Console.WriteLine(message);
            string strnum = Console.ReadLine();
            return int.TryParse(strnum, out result);
        }
        public static string Operadores(string message)
        {
            Console.WriteLine(message);
            string str3 = Console.ReadLine();
            return str3;
        }
        public static bool TryCompute(string str3, int num1, int num2, out int result)
        {
            bool temErro = false;
            result = 0;

            if (str3 == "+")
            {
                result = num1 + num2;
            }
            else if (str3 == "-")
            {
                result = num1 - num2;
            }
            else if (str3 == "*")
            {
                result = num1 * num2;
            }
            else if (str3 == "/")
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Não pode dividir por 0! Prima qualquer tecla para fechar!");
                    temErro = true;
                    Console.Read();
                }
                else
                {
                    result = num1 / num2;
                }
            }
            else if (str3 == "%")
            {
                result = num1 % num2;
            }
            else
            {
                temErro = true;
                Console.WriteLine("erro na introdução, recomece");
            }
            return temErro;
        }

      
    }
}
