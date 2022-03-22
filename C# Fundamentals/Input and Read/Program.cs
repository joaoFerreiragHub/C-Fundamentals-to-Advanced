using System;

namespace RestartV5.FirstSession
{
    class Program
    {
        static void Main(string[] args)
        {
            // variaveis
            /*tipos de dados numericos
            int num1 = 10;
            double num2 = 20.0;
            decimal num3 = 20.0m;
            bool isVisible = true;
            isVisible = false;*/

            int num1 = 10;
            int num2 = 20;
            int res = num1 + num2;

            // Console.WriteLine(num1 + num2);

            // Console.WriteLine($"{num1} + {num2} = {res}");


            //Console.WriteLine("insira um numero");
            //string strA = Console.ReadLine();

            //Console.WriteLine($"0 n. inserido foi: {strA}");

             Console.WriteLine("insira um numero");
             int num3 = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("insira outro numero");
             int num4 = Convert.ToInt32(Console.ReadLine());
             int resultado = num3 + num4;
             Console.WriteLine($"A some é {resultado}");

          
            /*Console.WriteLine("insira um numero");
            string num3 = Console.ReadLine();
            Console.WriteLine("insira outro numero");
            string num4 = Console.ReadLine();
            string resultado = num3 + num4;
            Console.WriteLine($"A some é {resultado}");*/

            //string diaSemana;
            //diaSemana = "Terça";

            //string nome = "João";

            //Console.WriteLine(nome);
            // Console.WriteLine(diaSemana);



            Console.Read();
}
}
}
