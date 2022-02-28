using System;

namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserir o valor do salário atual");
            int salario = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual é a percentagem? De 0 a 100, pode utilizar decimais");
            double salarioF = Convert.ToDouble(Console.ReadLine());


            if (salarioF >= 0 && salarioF <= 100)
            {
                Console.WriteLine($"O salário final é {(salarioF*salario/100) + salario}");
            }
            else
            {
                Console.WriteLine("Percetengem incorreta");
            }
        }
    }
}
