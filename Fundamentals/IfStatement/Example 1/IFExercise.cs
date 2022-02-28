using System;

namespace Exercicio05_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //ler 3 numeros da consola e apresenta-los por ordem
            //5,3,70
            int num1, num2, num3;

            num1 = InsertNumbers("Digite o 1º Numero:");
            num2 = InsertNumbers("Digite o 2º Numero:");
            num3 = InsertNumbers("Digite o 3º Numero:");


            //Ordena3Numeros();

            //Versão 1.0
            /*if(num1 > num2 && num1 > num3 && num2 > num3)
            {
                Console.WriteLine("A ordem: {0}, {1}, {2}", num1, num2, num3);
            }
            else if (num1 > num2 && num1 > num3 && num3 > num2)
            {
                Console.WriteLine("A ordem: {0}, {1}, {2}", num1, num3, num2);
            }
            else if (num2 > num1 && num2 > num3 && num3 > num1)
            {
                Console.WriteLine("A ordem: {0}, {1}, {2}", num2, num3, num1);
            }
            else if (num2 > num1 && num2 > num3 && num1 > num3)
            {
                Console.WriteLine("A ordem: {0}, {1}, {2}", num2, num1, num3);
            }
            else if (num3 > num2 && num3 > num1 && num2 > num1)
            {
                Console.WriteLine("A ordem: {0}, {1}, {2}", num3, num2, num1);
            }
           else if (num3 > num2 && num3 > num1 && num1 > num2)
            {
                Console.WriteLine("A ordem: {0}, {1}, {2}", num3, num1, num2);
            }
            else
            {
                Console.WriteLine("Introduziu erro");
            }*/


            // Versao 2.0 (nao funca a 100%)
             int aux = 0;

             if (num1 > num3)
             {
                 aux = num1;
                 num1 = num3;
                 num3 = aux;
             }
             else if (num1 > num2)
             {
                 aux = num1;
                 num1 = num2;
                 num2 = aux;
             }
             else if (num2 > num3)
             {
                 aux = num2;
                 num2 = num3;
                 num3 = aux;
             }
             Console.WriteLine("A ordem: {0}, {1}, {2}", num1, num2, num3);
             Console.Read();
        }
        //Versao 3.0
        /*public static void Ordena3Numeros()
        {
            var n1 = ReadInt("Insira o n.º 1");
            var n2 = ReadInt("Insira o n.º 2");
            var n3 = ReadInt("Insira o n.º 3");

            if (n1 > n2)
                Troca(ref n1, ref n2);
            if (n1 > n3)
                Troca(ref n1, ref n3);
            if (n2 > n3)
                Troca(ref n2, ref n3);

            Console.WriteLine($"{n1}, {n2}, {n3}");
        }

        static void Troca(ref int n1, ref int n2)
        {
            int aux = n1;
            n1 = n2;
            n2 = aux;
        }*/
        static int ReadInt(string mensagem)
        {
            Console.WriteLine(mensagem);
            return int.Parse(Console.ReadLine());
        }

        static int InsertNumbers(string message)
        {
            Console.WriteLine(message);
            string strnum = Console.ReadLine();
            return int.Parse(strnum);
        }

    }          
    
}
