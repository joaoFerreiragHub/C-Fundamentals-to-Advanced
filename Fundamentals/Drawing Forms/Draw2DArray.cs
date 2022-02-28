using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.App
{
    public class Draw2DArray
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
                    var line = Line(QuantosCaracteres(), QualSimbolo());
                    Print(line);
                    break;
                case 2:
                    var column = Column(QuantosCaracteres(), QualSimbolo());
                    Print(column);
                    break;
                case 3:
                    var triangle = Triangle(QuantosCaracteres(), QualSimbolo());
                    Print(triangle);
                    break;
                case 4:
                    var square = Square(QuantosCaracteres(), QualSimbolo());
                    Print(square);
                    break;
                case 5:
                    var emptySquare = EmptySquareCross(QuantosCaracteres(), QualSimbolo());
                    Print(emptySquare);
                    break;
                case 6:
                    var squareCross = EmptySquareCross(QuantosCaracteres(), QualSimbolo());
                    Print(squareCross);
                    break;
                case 7:
                    var emptyWithCross = EmptySquareWithCross(20, '#');
                    Print(emptyWithCross);
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
        public static char[,] Line(int length, char ch)
        {
            char[,] line = new char[1, length];

            for (int i = 0; i < length; i++)
            {
                line[0, i] = ch;
            }

            return line;

        }
        public static char[,] Column(int length, char ch)
        {
            char[,] column = new char[length, 1];

            for (int i = 0; i < length; i++)
            {
                column[i, 0] = ch;
            }
            return column;
        }
        public static char[,] Triangle(int length, char ch)
        {
            char[,] triangle = new char[length, length];

            for (int i = 0; i < length; i++)
            {
                for (int j = 1; j < i; j++)
                    triangle[i, j] = ch;
            }
            return triangle;
        }
        public static char[,] Square(int length, char ch)
        {
            char[,] square = new char[length, length];

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                    square[i, j] = ch;
            }
            return square;
        }
        public static char[,] EmptySquare(int length, char ch)
        {
            char[,] emptySquare = new char[length, length];

            int max = length - 1;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (i == 0 || j == 0 || i == max || j == max)
                        emptySquare[i, j] = ch;
                }
            }
            return emptySquare;
        }
        public static char[,] EmptySquareCross(int length, char ch)
        {
            char[,] crosSquare = new char[length, length];

            int max = length - 1;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (i == 0 || j == 0 || i == max || j == max || i == j || ((i + j) == max))
                        crosSquare[i, j] = ch;
                }
            }
            return crosSquare;
        }
        public static char[,] EmptySquareWithCross(int length, char ch)
        {
            char[,] emptyCrosSquare = new char[length, length];

            int max = length - 1;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (i == 0 || j == 0 || i == max || j == max || i == (length / 2) || j == (length / 2))
                        emptyCrosSquare[i, j] = ch;
                }
            }
            return emptyCrosSquare;
        }
        public static void Print(char[,] mat)
        {
            int numLinhas = mat.GetLength(0);
            int numColunas = mat.GetLength(1);

            for (int i = 0; i < numLinhas; i++)
            {
                for (int j = 0; j < numColunas; j++)
                {
                    if (mat[i, j] != null)
                        Console.Write(mat[i, j] + " ");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }

}
