using System;
using System.Threading;

namespace JogoGalo.App
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Jogo do Galo";
            string jogador = "X";
            string winner = null;

            while (true)
            {
                Console.Clear();
                Jogo.Print();

                Console.WriteLine("Pressione uma tecla para jogar");
                Console.Read();

                var move = Jogo.ReadMove();
                Jogo.Move(move[0], move[1], jogador);

                if (Jogo.PlayerWon())
                {
                    winner = jogador;
                    break;
                }

                // (condicao) ? expressao se verdade : expressao se falso;
                jogador = (jogador == "X") ? "0" : "X";
            }

            if (winner != null)
            {
                Console.WriteLine($"O jogador {jogador} ganhou.");
            }

            Console.WriteLine();

            Exit();
        }

        private static void Exit()
        {
            Console.WriteLine("\n\n\n");
            Console.WriteLine("Prima qq tecla para sair");
            Console.Read();
        }
    }
}
