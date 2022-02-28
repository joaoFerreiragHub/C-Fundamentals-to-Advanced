using System;

namespace JogoGalo.App
{
    class Jogo
    {
        static Random rnd = new Random();
        static Random rnd1 = new Random();

        static string[,] tabuleiro = new string[,]
        {
            { ".", ".", "." },
            { ".", ".", "." },
            { ".", ".", "." }
         };

        internal static void Start(string v)
        {
            rnd1 = rnd;
            
            throw new NotImplementedException();
        }

        internal static void Move(int line, int col, string player)
            => tabuleiro[line, col] = player;

        internal static bool ValidateMove()
        {
            throw new NotImplementedException();
           // return char.IsDigit(tabuleiro[0, 1]); ;
        }

        internal static int[] ReadMove()
        {
            int linha = rnd.Next(0, 3);
            int col = rnd.Next(0, 3);

            return new int[] { linha, col };
        }

        internal static bool PlayerWon()
        {
            return false;
        }

        internal static bool IsFinished()
        {
            throw new NotImplementedException();
        }

        public static void Print()
        {
            for (int i = 0; i < tabuleiro.GetLength(0); i++)
            {
                for (int j = 0; j < tabuleiro.GetLength(1); j++)
                {
                    Console.Write(tabuleiro[i, j] + " ");
                }

                Console.WriteLine();
            }
        }

        /* Principais tarefas / o que ter em consideração
 * 
 * - Desenhar o tabuleiro
 * - Criar o tabuleiro 3X3
 * - Inicializar o tabuleiro 
 * - Símbolos de jogo 
 * - Identificar se o último a jogar ganhou
 *     - Validar as linhas
 *     - Validar as colunas
 *     - Validar as diagonais
 * - Verificar se o jogo terminou (tabuleiro preenchido)
 * - Atualizar o jogo (alternar jogadores)
 * - Validar se posição está preenchida
 * - Ler e validar jogada
 * 
 * */


    }
}
