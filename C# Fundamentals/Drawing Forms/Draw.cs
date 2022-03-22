using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.App
{
    class Draw
    {
        public static void DesenharMenu()
        {

            Console.WriteLine(" 1) Desenhar Linha");
            Console.WriteLine(" 2) Desenhar Coluna");
            Console.WriteLine(" 3) Desenhar Triangulo");
            Console.WriteLine(" 4) Desenhar Quadrado");
            Console.WriteLine(" 5) Desenhar Quadrado vazio");
            Console.WriteLine(" 6) Desenhar Quadrado Cruz cruzada");
            Console.WriteLine(" 7) Desenhar Quadrado Cruz");
            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.WriteLine(" 0) Sair");
        }
        public static void TenteDeNovo(string opcao)
        {
            DesenharMenu();
            Console.WriteLine("\n \n Tente de novo!");
            opcao = Console.ReadLine();
            LerOpcao(opcao);
        }
        public static void LerOpcao(string opcao)
        {
            bool success = false;
            success = int.TryParse(opcao, out int opt);
            if (success)
            {
                if (opt < 0 || opt > 30)
                {
                    Console.Clear();
                    TenteDeNovo(opcao);
                }
                else
                {
                    Console.Clear();
                    Desenhar(opt);
                }
            }
            else
            {
                Console.Clear();
                TenteDeNovo(opcao);
            }
        }
        public static void Desenhar(int opt)
        {
            Console.Clear();
            switch (opt)
            {
                case 1:
                    Line(QuantosCaracteres(), QualSimbolo());
                    break;
                case 2:
                    Column(QuantosCaracteres(), QualSimbolo());
                    break;
                case 3:
                    Triangle(QuantosCaracteres(), QualSimbolo());
                    break;
                case 4:
                    Square(QuantosCaracteres(), QualSimbolo());
                    break;
                case 5:
                    EmptySquare(QuantosCaracteres(), QualSimbolo());
                    break;
                case 6:
                    CrossSquare(QuantosCaracteres(), QualSimbolo());
                    break;
                case 7:
                    CrossSquare2(QuantosCaracteres(), QualSimbolo());
                    break;
                case 0:
                    Console.WriteLine("*********** A fechar a Aplicação *******************");
                    break;
            }
        }
        public static int QuantosCaracteres()
        {
            Console.WriteLine(" 1) Quantos caracteres");
            try
            {
                string howMan = Console.ReadLine();
                int howManInt = int.Parse(howMan);
                if (howManInt > 0 && howManInt < 30)
                {
                    return howManInt;
                }
                else
                {
                    QuantosCaracteres();
                }
                return howManInt;
            }
            catch
            {
                Console.WriteLine("Nao coloque numeros negativos ou letras");
                QuantosCaracteres();
                return 0;
            }
        }
        public static char QualSimbolo()
        {
            try
            {
                Console.WriteLine(" 1) Qual o Simbolo?");
                string simbul = Console.ReadLine();
                char l = char.Parse(simbul);
                if ((l >= '0' && l <= '9') || (l >= 'A' && l <= 'Z') || (l >= 'a' && l <= 'z'))
                {
                    Console.WriteLine(" Nao utilize numeros nem letras, apenas simbulos\n");
                    QualSimbolo();
                    return '0';
                }
                else
                {
                    return l;
                }
            }
            catch
            {
                Console.WriteLine("Nao coloque numeros negativos ou letras");
                QualSimbolo();
                return '0';
            }
        }
        public static void Line(int howMany, char ch)
        {
            Console.Clear();
            for (int i = 0; i < howMany; i++)
            {
                Console.Write(ch);
            }
        }
        public static void Column(int howMany, char ch)
        {
            Console.Clear();
            for (int i = 0; i <= howMany - 1; i++)
            {
                Console.WriteLine(ch);
            }
        }
        public static void Triangle(int howMany, char ch)
        {
            Console.Clear();
            for (int i = 0; i <= howMany; i++)
            {
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(ch);
                }
                Console.WriteLine("");
            }
        }
        public static void Square(int howMany, char ch)
        {
            Console.Clear();
            for (int i = 1; i <= howMany * howMany; i++)
            {
                if (i % howMany == 0)
                {
                    Console.WriteLine("*");
                }
                else
                {
                    Console.Write("*");
                }
            }
        }
        public static void EmptySquare(int howMany, char ch)
        {
            Console.Clear();
            int quantosTemos = 1;
            for (int i = 1; i <= howMany * howMany; i++)
            {
                if (i % howMany == 0)
                {
                    Console.WriteLine("*");
                    quantosTemos++;
                }
                else
                {
                    if (quantosTemos <= 1 || i % howMany == 1 || quantosTemos == howMany)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }
        }
        public static void CrossSquare(int howMany, char ch)
        {
            Console.Clear();
            for (int altura = 0; altura < howMany; altura++)
            {
                if (altura == 0 || altura == howMany - 1)
                {
                    for (int comprimento = 0; comprimento < howMany; comprimento++)//comprimento
                    {
                        Console.Write(ch + " ");
                    }
                }
                else
                {
                    for (int comprimento = 0; comprimento < howMany; comprimento++)
                    {
                        if (comprimento == 0 || comprimento == howMany - 1)//altura (no inicio ou no fim)
                        {
                            Console.Write(ch + " ");
                        }
                        else if (comprimento == altura) //|| comprimento == howMany - 1)//cruzado quando a altura é igual ao comprimento ou 
                        {
                            Console.Write(ch + " ");
                        }
                        else if (altura == (howMany - 1) - comprimento) //cruzado junto aos cantos
                        {
                            Console.Write(ch + " ");
                        }
                        else
                        {
                            Console.Write("  ");//espaços vazios
                        }
                    }
                }
                Console.WriteLine();

            }
        }
        public static void CrossSquare2(int howMany, char ch)
        {
            Console.Clear();
            for (int altura = 0; altura < howMany; altura++)
            {
                if (altura == 0 || altura == howMany - 1)
                {
                    for (int comprimento = 0; comprimento < howMany; comprimento++)
                    {
                        Console.Write(ch + " ");
                    }
                }
                else
                {
                    for (int comprimento = 0; comprimento < howMany; comprimento++)
                    {
                        if (comprimento == 0 || comprimento == howMany - 1)
                        {
                            Console.Write(ch + " ");
                        }
                        else if (comprimento == (howMany - 1) / 2)
                        {
                            Console.Write(ch + " ");
                        }
                        else if (altura == (howMany - 1) / 2)
                        {
                            Console.Write(ch + " ");
                        }
                        else
                        {
                            Console.Write("  ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

