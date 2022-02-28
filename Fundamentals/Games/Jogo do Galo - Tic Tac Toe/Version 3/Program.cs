using System;

namespace Galo3daWeb
{
    class Program
    {

        static int contador = 0;
        static string[] tabuleiro = new string[9];
        static  string jogoNovo = "Sim";
        static void InicializaroTabuleiro()
        {
            for (int i = 0; i < 9; i++)
            {
                tabuleiro[i] = i.ToString();
            }
        }

        static void JogarDeNovo(string message)
        {
            Console.WriteLine(message + "Quer jogar de novo ? Sim / Nao");
            if (Console.ReadLine().Equals("Sim"))
                jogoNovo.Equals("Sim");
            else
                jogoNovo.Equals("Nao");
        }

        static void Main(string[] args)
        {

            Introducao();
            while (jogoNovo.Equals("Sim"))
            {
                InicializaroTabuleiro();
                while (AlguemGanhou() == false && contador < 9)
                {
                    QuemJoga("X");
                    if (AlguemGanhou() == true)
                        break;
                    QuemJoga("O");
                }
                if (AlguemGanhou() == true)
                    JogarDeNovo("Parabéns! Venceu!");
                else
                    JogarDeNovo("Empataram!");
            }
        }
        static void QuemJoga(string jogador)
        {
            Console.Clear();

            Console.WriteLine("Jogador: " + jogador);
            int campo;

            while (true)
            {
                Console.WriteLine("Introduza o campo:");
                DesenharTabuleiro();
                campo = Convert.ToInt32(Console.ReadLine());
                if (campo < 0 || campo > 9 || (tabuleiro[campo].Equals("X")) || (tabuleiro[campo].Equals("O")))
                    Console.WriteLine("Opção Invaldia");
                else
                    break;
            }
            tabuleiro[campo] = jogador;
        }

        static void Introducao()
        {
            Console.Title = ("Jogo do Galo");
            Console.WriteLine("Vamos jogar ao Jogo do Galo!\n");
            Console.WriteLine("Clica em qualquer tecla para começar");
            Console.ReadLine();
            Console.Clear();
        }
 


        public static void DesenharTabuleiro()
        {
            for (int i = 0; i < 7; i += 3)
                Console.WriteLine(tabuleiro[i] + "|" + tabuleiro[i + 1] + "|" + tabuleiro[i + 2]);
        }
        static bool AlguemGanhou()
        {
            for (int i = 0; i < 7; i+=3)
            {
                if (tabuleiro[i].Equals(tabuleiro[i + 1]) && tabuleiro[i + 1].Equals(tabuleiro[i + 2]))
                {
                    return true;
                }
            }
            if (tabuleiro[0].Equals(tabuleiro[3]) && tabuleiro[3].Equals(tabuleiro[6]))
                return true;
            if (tabuleiro[1].Equals(tabuleiro[4]) && tabuleiro[4].Equals(tabuleiro[7]))
                return true;
            if (tabuleiro[2].Equals(tabuleiro[5]) && tabuleiro[3].Equals(tabuleiro[8]))
                return true;
            if (tabuleiro[2].Equals(tabuleiro[4]) && tabuleiro[4].Equals(tabuleiro[6]))
                return true;
            if (tabuleiro[0].Equals(tabuleiro[4]) && tabuleiro[4].Equals(tabuleiro[8]))
                return true;
            else
                return false;
        }






    }
}
