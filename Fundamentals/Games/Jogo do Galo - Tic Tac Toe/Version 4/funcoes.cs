using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaloNaAula
{
    class funcoes
    {
        internal static bool AlguemGanhou()
        {
            if ((tabuleiro[0, 0].Equals(tabuleiro[0, 1])) && (tabuleiro[0, 1].Equals(tabuleiro[0, 2])))
                return true;
            if ((tabuleiro[1, 0].Equals(tabuleiro[1, 1])) && (tabuleiro[1, 1].Equals(tabuleiro[1, 2])))
                return true;
            if ((tabuleiro[2, 0].Equals(tabuleiro[2, 1])) && (tabuleiro[2, 1].Equals(tabuleiro[2, 2])))
                return true;
            if ((tabuleiro[0, 0].Equals(tabuleiro[1, 0])) && (tabuleiro[1, 0].Equals(tabuleiro[2, 0])))
                return true;
            if ((tabuleiro[0, 1].Equals(tabuleiro[1, 1])) && (tabuleiro[1, 1].Equals(tabuleiro[2, 1])))
                return true;
            if ((tabuleiro[0, 2].Equals(tabuleiro[1, 2])) && (tabuleiro[1, 2].Equals(tabuleiro[2, 2])))
                return true;
            if ((tabuleiro[0, 0].Equals(tabuleiro[1, 1])) && (tabuleiro[1, 1].Equals(tabuleiro[2, 2])))
                return true;
            if ((tabuleiro[0, 2].Equals(tabuleiro[1, 1])) && (tabuleiro[1, 1].Equals(tabuleiro[2, 0])))
                return true;
            else
                return false;
        }

        public static bool ValdiarJogada(int linha, int coluna)
        {
            return char.IsDigit(tabuleiro[linha, coluna]);
        }

        public static int[] LerJogada(char player)
        {
            var jogada = new int[2];

            do
            {
                try
                {
                    int campo;
                    do
                    {
                        Console.WriteLine("\t É o turno do jogador: {0} ", player);
                        campo = int.Parse(Console.ReadLine());
                        if (campo == 1)
                            jogada = new int[] { 0, 0 };
                        else if (campo == 2)
                            jogada = new int[] { 0, 1 };
                        else if (campo == 3)
                            jogada = new int[] { 0, 2 };
                        else if (campo == 4)
                            jogada = new int[] { 1, 0 };
                        else if (campo == 5)
                            jogada = new int[] { 1, 1 };
                        else if (campo == 6)
                            jogada = new int[] { 1, 2 };
                        else if (campo == 7)
                            jogada = new int[] { 2, 0 };
                        else if (campo == 8)
                            jogada = new int[] { 2, 1 };
                        else if (campo == 9)
                            jogada = new int[] { 2, 2 };
                    } while (campo <= 0 || campo > 9);
                }
                catch
                {
                    Console.WriteLine("\n Introduza um número!");
                }
            } while (ValdiarJogada(jogada[0], jogada[1]) == false);
            return jogada;
        }

        internal static int Jogada(int linha, int coluna, char player)
        {
            rondas++;
            return tabuleiro[linha, coluna] = player;
        }

        public static void DesenharTabuleiro2()
        {
            
            Console.Clear();
            Introducao();
            for (int i = 0; i < tabuleiro.GetLength(0); i++)
            {
                for (int j = 0; j < tabuleiro.GetLength(1); j++)
                {
                    Console.Write(tabuleiro[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static void Introducao()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = ("Jogo do Galo");
            Console.WriteLine("\t Vamos jogar ao Jogo do Galo!\n\n");
        }

        static char[,] tabuleiro =
            {
                { '1','2','3'},
                { '4','5','6'},
                { '7','8','9'}
            };
        public static int rondas = 0;
    }
}
