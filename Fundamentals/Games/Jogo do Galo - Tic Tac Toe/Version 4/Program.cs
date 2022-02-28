using System;

namespace GaloNaAula
{
    class Program
    {
        static void Main(string[] args)
        {
            char player = 'X';
            funcoes.DesenharTabuleiro2();
            while (funcoes.AlguemGanhou() == false && funcoes.rondas < 9)
            {
               
                player = (player == 'X') ? 'O' : 'X';               
                int[] play = funcoes.LerJogada(player);        
                bool validada = funcoes.ValdiarJogada(play[0], play[1]);
                funcoes.Jogada(play[0], play[1], player);
                funcoes.DesenharTabuleiro2();
                if (funcoes.AlguemGanhou() == true)
                {
                    Console.WriteLine("\n\n Parabéns! Venceu!\n");
                    break;
                }
            }
            if (funcoes.AlguemGanhou() == false)
                Console.WriteLine("\n\n Empataram!\n");

            Console.WriteLine("\n\n\n");
            Console.WriteLine("Prima qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}
