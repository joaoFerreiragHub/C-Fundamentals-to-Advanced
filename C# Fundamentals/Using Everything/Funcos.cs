using System;

namespace Exercicios
{
    public class Funcos
    {
        public static string AskmeSomething()
        {
            Console.WriteLine("Introduza 1 numero:");
            string str1 = Console.ReadLine();

            return str1;
        }

        public static int IntConvert()
        {
            int num = int.Parse(AskmeSomething());
            return num;
        }

        //*******************************************************************

        public static void VogalConsoante()
        {
            Console.WriteLine("Introduza uma letra");
            string str1 = Console.ReadLine();
            char vogal = char.Parse(str1);
            if (vogal == 'a' || vogal == 'e' || vogal == 'i' || vogal == 'o' || vogal == 'u')
                Console.WriteLine("É vogal");
            else
                Console.WriteLine(" É consoante");
        }

        public enum Extenso
        {
          zero = 0,
          Um = 1,
          Dois = 2,
          Três = 3,
          Quatro = 4,
          cinco = 5
        }
        public static void Triangulo()
        {
            Console.WriteLine("Introduzir lado 1 ");
            string str1 = Console.ReadLine();
            int lado1 = int.Parse(str1);

            Console.WriteLine("Introduzir lado 2: ");
            string str2 = Console.ReadLine();
            int lado2 = int.Parse(str2);

            Console.WriteLine("Introduzir lado: ");
            string str3 = Console.ReadLine();
            int lado3 = int.Parse(str3);

            Console.WriteLine("Introduzir angulo: ");
            string str4 = Console.ReadLine();
            int angulo = int.Parse(str4);

            int soma = lado1 + lado2;
            int soma2 = lado2 + lado3;
            int soma3 = lado1 + lado3;
            if (soma > lado3 || soma2 > lado1 || soma3 > lado2)
            {
                if (lado1 == lado2 && lado1 == lado3)
                    Console.WriteLine("É um triangulo equilátero");
                else if ((lado1 == lado2 || lado1 == lado3 || lado2 == lado3))
                    Console.WriteLine("É um triangulo isósceles");
                else
                    Console.WriteLine("É um triangulo escaleno");
            }
            else
            {
                Console.WriteLine("Não é um triangulo");
            }
        }
        public static void ValorProduto()
        {
            Console.WriteLine("Introduzir preço do artigo: ");
            string str1 = Console.ReadLine();
            double preço = double.Parse(str1);
            Console.WriteLine("Introduzir o tipo de artigo: ");
            string str2 = Console.ReadLine();


            if (str2 == "essenciais")
            {
                preço = preço + (preço * 0.05);
                Console.WriteLine("O preço final é {0}", preço);
            }
            else if (str2 == "luxo")
            {
                preço = preço + (preço * 0.3);
                Console.WriteLine("O preço final é {0}", preço);
            }
            else
            {
                preço = preço + (preço * 0.2);
                Console.WriteLine("O preço final é {0}", preço);

            }
        }
        public static void OrdemCrescente()
        {
            {
                Console.WriteLine("Introduzir 1º numero: ");
                string str1 = Console.ReadLine();
                int num1 = int.Parse(str1);
                Console.WriteLine("Introduzir 2º numero: ");
                string str2 = Console.ReadLine();
                int num2 = int.Parse(str2);
                Console.WriteLine("Introduzir 3º numero: ");
                string str3 = Console.ReadLine();
                int num3 = int.Parse(str3);

                if (num1 > num2)
                    Troca(ref num1, ref num2);
                if (num1 > num3)
                    Troca(ref num1, ref num3);
                if (num2 > num3)
                    Troca(ref num2, ref num3);

                Console.WriteLine($"{num1}, {num2}, {num3}");
            }

            static void Troca(ref int n1, ref int n2)
            {
                int aux = n1;
                n1 = n2;
                n2 = aux;
            }
        }
        /*
           if ((num1 > num2) && (num1 > num3))
        {
            if (num2 > num3)
            {
                Console.WriteLine("{0} {1} {2}", num1, num2, num3);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", num1, num3, num2);
            }
        }
        else if ((num2 > num1) && (num2 > num3))
        {
            if (num1 > num3)
            {
                Console.WriteLine("{0} {1} {2}", num2, num1, num3);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", num2, num3, num1);
            }
        }
        else if ((num3 > num1) && (num3 > num2))
        {
            if (num1 > num2)
            {
                Console.WriteLine("{0} {1} {2}", num3, num1, num2);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", num3, num2, num1);
            }
        */
        public static void isLeapYear()
        {
            Console.WriteLine("Introduzir 1º nota: ");
            string str1 = Console.ReadLine();
            int year = int.Parse(str1);

            Console.WriteLine("Year = " + year);
            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("Leap Year!");
            }
            else
            {
                Console.WriteLine("Not a Leap Year!");
            }
        }
        public static void Ternario()
        {
            Console.WriteLine("Introduzir 1º nota: ");
            string str1 = Console.ReadLine();
            int num1 = int.Parse(str1);
            int num = 10;

            var result = num1 > num ? "Parabéns" : "Ups, deve marcar novo exame.";

            Console.WriteLine(result);
        }
        public static void AprovarFormando()
        {
            Console.WriteLine("Introduzir 1º nota: ");
            string str1 = Console.ReadLine();
            int num1 = int.Parse(str1);
            Console.WriteLine("Introduzir 2º nota: ");
            string str2 = Console.ReadLine();
            int num2 = int.Parse(str2);
            int notaFinal = (num1 + num2) / 2;


            if (num1 < 8 && num2 < 8)
                Console.WriteLine("Reprovou");
            else
                Console.WriteLine("A sua nota final é {0} em 20 valores;", notaFinal);
        }
        public static void MaiorDeTres()
        {
            Console.WriteLine("1º Numero: ");
            string str1 = Console.ReadLine();
            int num1 = int.Parse(str1);
            Console.WriteLine("2º Numero: ");
            string str2 = Console.ReadLine();
            int num2 = int.Parse(str2);
            Console.WriteLine("3º Numero: ");
            string str3 = Console.ReadLine();
            int num3 = int.Parse(str3);
            int oMaior = 0;

            if (num1 > num2 && num1 > num3)
                oMaior = num1;
            else if (num2 > num1 && num2 > num3)
                oMaior = num2;
            else
                oMaior = num3;

            Console.WriteLine("o maior numero é: {0}", oMaior);
        }
        public static void SalarioSemanal()
        {
            Console.WriteLine("Quanto recebe por hora? ");
            string str1 = Console.ReadLine();
            int num1 = int.Parse(str1);
            Console.WriteLine("Quantas horas trabalhou? ");
            string str2 = Console.ReadLine();
            int num2 = int.Parse(str2);
            int salarioFinal;

            if (num2 > 40)
            {
                int horasExtra = (num2 - 40) * num1 * 2;
                salarioFinal = (num1 * 40) + horasExtra;
                Console.WriteLine("O salario final é {0}", salarioFinal);
            }
            else
            {
                salarioFinal = num1 * num2;
                Console.WriteLine("O salario final é {0}", salarioFinal);
            }


        }
        public static void ParEPositivo()
        {
            int num = int.Parse(AskmeSomething());

            if (num % 2 == 0 && num > 0)
                Console.WriteLine(num);
            else
                Console.WriteLine("Numero é impar, negativo ou ambos");
        }
        public static void ConverterInteiro()
        {
            double var = double.Parse(AskmeSomething());
            int nums = Convert.ToInt32(var);

            Console.WriteLine(nums);
        }
        public static void VerificarResultado()
        {
            Console.WriteLine(2 == 3);
            Console.WriteLine(8 != 12);
            Console.WriteLine(14 > 15);
            Console.WriteLine(true == false);
            Console.WriteLine('a' == 'a');
            Console.WriteLine('a' == 'b');
            Console.WriteLine((2 < 3) && (3 > 4));
            Console.WriteLine((2 < 3) || (3 > 4));
            Console.WriteLine(!((2 < 3) || (3 > 4)));
        }
        //parte 2


        // parte 1
        public static int Area()
        {
            int altura = int.Parse(AskmeSomething());
            int largura = int.Parse(AskmeSomething());
            int area = altura * largura;
            Console.WriteLine("A area é {0}", area);
            return area;
        }

        public static double calcularSomaDivisaoModulo()
        {
            Console.WriteLine("Escolha uma opcao:\n 1) Soma\n 2) Divisão\n 3) Resto");
            int opcao = IntConvert();

            Console.Clear();
            if (opcao == 1)
            {
                int n1 = IntConvert();
                int n2 = IntConvert();
                int soma = n1 + n2;
                Console.WriteLine("O resultado da soma é {0}", (double)soma);
                return (double)soma;

            }
            else if (opcao == 2)
            {
                double n1 = double.Parse(AskmeSomething());
                double n2 = double.Parse(AskmeSomething());
                double divisao = n1 / n2;
                Console.WriteLine("O resultado da divisao é {0}", divisao);
                return divisao;

            }
            else if (opcao == 3)
            {
                double n1 = double.Parse(AskmeSomething());
                double n2 = double.Parse(AskmeSomething());
                double resto = n1 % n2;
                Console.WriteLine("O resultado do resto é {0}", resto);
                return resto;

            }
            else
            {
                Console.WriteLine("Algo correu mal, tente de novo.");
                return 0;
            }
            Console.Read();
        }

        public static void ShowDecimal()
        {
            decimal num1 = 8.456796m;
            // decimal num1r = Math.Round(num1, 2);
            decimal num2 = 9.8m;
            //decimal num2r = Math.Round(num2, 2);
            decimal num3 = 3.12345m;
            decimal num4 = 6.0m;

            Console.WriteLine("{0:0.000} {1:0.000} {2:0.000} {3:0.000}", num1, num2, num3, num4);
            Console.WriteLine("{0:0.0} {1:0.0} {2:0.0} {3:0.0}", num1, num2, num3, num4);
            Console.WriteLine("{0:0} {1:0} {2:0} {3:0}", num1, num2, num3, num4);
        }

        public static void ShowDecimalPercentage()
        {
            decimal num1 = 8.456796m;
            // decimal num1r = Math.Round(num1, 2);
            decimal num2 = 9.8m;
            //decimal num2r = Math.Round(num2, 2);
            decimal num3 = 3.12345m;
            decimal num4 = 6.0m;

            Console.WriteLine("{0:0.000}% {1:0.000}% {2:0.000}% {3:0.000}%", num1 * 100, num2 * 100, num3 * 100, num4 * 100);
            Console.WriteLine("{0:0.0}% {1:0.0}% {2:0.0}% {3:0.0}%", num1 * 100, num2 * 100, num3 * 100, num4 * 100);
            Console.WriteLine("{0:0}% {1:0}% {2:0}% {3:0}%", num1 * 100, num2 * 100, num3 * 100, num4 * 100);
        }

        public static void MostrarParteInteira()
        {
            double parteInteira = double.Parse(AskmeSomething());
            int pInteira = (int)parteInteira;

            Console.WriteLine(pInteira);
            //(int)parteinteira
        }

        public static void MostrarNome()
        {
            string name = AskmeSomething();
            string lastName = AskmeSomething();

            Console.WriteLine("{0} {1} acabou de ganhar o 1º prémio. Parabéns!", name, lastName);
        }

        public static void Media()
        {
            int media = (IntConvert() + IntConvert()) / 2;

            Console.WriteLine("A média é: {0}", media);
        }

        public static void ConverterToEuros()
        {
            double dollar = IntConvert();
            double euro;
            double converter = 1.1579;

            euro = converter * dollar;

            Console.WriteLine("São {0}€", euro);
        }

        public static void ConvertTemperature()
        {

            Console.WriteLine("What's the temperature(Fahrenheit)");
            double temp = double.Parse(Console.ReadLine());

            double celcius = (temp - 32) * 5 / 9;

            Console.WriteLine("Estão {0} : ", celcius);
        }

        public static void PreçoIvaFixo()
        {
            Console.WriteLine("Intrduza o Preço: ");
            double preco = double.Parse(Console.ReadLine());
            double iva = 0.23;
            double precoFinal = (preco * iva) + preco;

            Console.WriteLine("O preço com o IVA é : {0}euros\n preço base era: {1}", precoFinal, preco);
        }
        public static void PreçoBaseComIva()
        {
            Console.WriteLine("Intrduza o Preço: ");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Intrduza o IVA: ");
            double iva = double.Parse(Console.ReadLine());
            double precoFinal = (preco * iva) + preco;

            Console.WriteLine("O preço com o IVA é : {0}euros\n preço base era: {1}", precoFinal, preco);
        }

        public static void ConverterSegundosParaHoras()
        {
            Console.WriteLine("Intrduza ós segundos: ");
            double segundo = double.Parse(Console.ReadLine());
            double hora = segundo / 3600;
            double minutes = segundo / 60 % 60;
            double seconds = segundo % 60;


            Console.WriteLine("Conversão final {0}:{1}:{2}", (int)hora, (int)minutes, (int)seconds);
        }

        public static void QuantoGastou()
        {
            double pdia = 120;

            int dias = 5;
            double med = pdia;
            for (int i = 0; i <= dias; i++)
            {

                med = (med * 0.20) + med;
                Console.WriteLine(i + " " + (int)med);
            }


        }

        public static void SalarioStand()
        {
            Console.WriteLine("QUanto recebe por mês: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a comissão por carro vendido: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantos automoveis vendeu: ");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a % sobre as vendas: ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor das vendas: ");
            int v = int.Parse(Console.ReadLine());

            int comissao = (y / 100) * p;
            int vendas = (p / 100) * v;

            int valorFinal = x + comissao + vendas;

            Console.WriteLine("O salario mensal é de: {0}", valorFinal);
        }

        public static void TocarValor()
        {
            Console.WriteLine("qual o valor de A:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("qual o valor de B:");
            int b = int.Parse(Console.ReadLine()); ;
            (a, b) = (b, a);
            Console.WriteLine("O valor de A é: {0} e o valor de B é: {1}", a, b);

            (b, a) = (a, b);
            Console.WriteLine("O valor de A é: {0} e o valor de B é: {1}", a, b);

        }

        public static void MaisUmMenosUm()
        {
            Console.WriteLine("Introduza um numero");
            int a = int.Parse(Console.ReadLine());
            int maisUm = a + 1;
            int menosUm = a - 1;

            Console.WriteLine(" O valor anterior ao introduzido é {0}, o valor introduzido foi {1} e o numero a seguir é {2}", menosUm, a, maisUm);
        }
    }
}
;