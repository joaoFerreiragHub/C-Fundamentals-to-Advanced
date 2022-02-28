using System;
using System.Linq;
using System.Linq.Expressions;

namespace tpc

/*
IndexOf
SubString
Contains
ToLower / ToUpper
Split
Trim / TrimEnd  / TrimStart
Replace
Remove
join
PadLeft / PadRight
IsNullOrEmpty
StartsWith
LastIndexOfAny

IsNullOrWhiteSpace
LLastIndexOf




*/

{
    class Program
    {
        static void Main(string[] args)
        {

            //string teste = " 5 + 5";
            //Console.WriteLine("Introduza 1 calculo:  (Exemplo: 10 * 5"));
            //string str = Console.ReadLine();


            /*Console.WriteLine("Introduza uma palavra ou frase");
            string frase = Console.ReadLine();
            string caps= frase.ToUpper();

            Console.WriteLine(caps);
            Console.WriteLine(frase.ToLower());*/

            /* Console.WriteLine("Introduza uma frase");
             string frase = Console.ReadLine();
             string trim = frase.Trim();
             Console.WriteLine(trim);

             string trimS = frase.TrimStart();
             Console.WriteLine(trimS);

             string trimE = frase.TrimStart();
             Console.WriteLine(trimE);*/

            /* string str = "This is a test";
             str = str.Replace(" ", "C#");
             Console.WriteLine(str);*/

            // Remove

            /*// original string
            Console.WriteLine("Introduza uma frase");
            String str = Console.ReadLine();
            Console.WriteLine("New String1 : " + str.Remove(0, str.IndexOf(" ")));
            Console.WriteLine("New String1 : " + str.Remove(str.IndexOf(" ") + 1));
            Console.WriteLine("New String2 : " + str.Remove(5, 3));*/

            /* Console.WriteLine("Introduza uma frase");
             String str = Console.ReadLine();
             string testar = "Estamos";
             str.StartsWith(testar);*/


            /*int[] array = new int[3];
            for (int i = 0; i <array.Length; i++)
            {
                Console.WriteLine("Introduza numeros");
                String str = Console.ReadLine();
                int test = int.Parse(str);
                array[i] = test;
            }

            string s1 = string.Join(", ", array);
            Console.WriteLine("resultado final" + s1);*/

            // Pad right / pad left
            Console.WriteLine("Introduza uma frase");
            String str = Console.ReadLine();
            Console.WriteLine("String : " + str);
            Console.WriteLine("Esquerda :'{0}'", str.PadLeft(2));
            Console.WriteLine("Direita :'{0}'",  str.PadRight(13));
            Console.WriteLine("Esquerda :'{0}'", str.PadLeft(20));





            /* string Soma = "+";
             string Multiplicar = "*";

             if (str.Contains(Soma))
             {
                 Console.WriteLine(" "+ str.Substring(0, str.IndexOf('+')));
                 Console.WriteLine(str.Substring(str.IndexOf('+') + 1));
                 int sum = str.Split(new char[] { '+' })
                                .Select(n => Int32.Parse(n))
                                .Sum();
                 Console.WriteLine(sum);

             }else if(str.Contains(Multiplicar))
             {
                 Console.WriteLine(str.Substring(0, str.IndexOf('*')));
                 Console.WriteLine(str.Substring(str.IndexOf('*') + 1));
                 string primeiraparte = str.Substring(0, str.IndexOf('*'));
                 string Segundaparte = (str.Substring(str.IndexOf('*') + 1));

                 int multiplica = int.Parse(primeiraparte) * int.Parse(Segundaparte);
                 Console.WriteLine(multiplica);
             }*/

            Console.Read();
        }
    }
}
