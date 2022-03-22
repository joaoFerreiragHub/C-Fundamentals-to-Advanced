using System;

namespace School.App
{

    class Program
    {
        static void Main(string[] args)
        {
            // DRAW *************************************************************************************

            var exit = false;
            do
            {
                Console.Clear();
                Draw.DesenharMenu();
                string opcao = Console.ReadLine();
                Draw.LerOpcao(opcao);
            } while (exit);

            // DRAW **************************************************************************************

            // Draw2DArray *******************************************************************************

            var sair = false;
            do
            {
                Console.Clear();
                Draw2DArray.DesenharMenu();
                string opcao2D = Console.ReadLine();
                Draw2DArray.LerOpcao(opcao2D);
                Console.Read();
            } while (sair);

            // Draw2DArray *******************************************************************************

            /*
            // Matrizes *******************************************************************************

             int[,] nums = new int[2, 5];

            // inicializar matrizes
            var contador = 1;

            for (int linha = 0; linha < 2; linha++)
            {
                for (int col = 0; col < 5; col++)
                {
                    nums[linha, col] = contador++;
                }
            }

            // inicializar os numeros de 1 a 2*5
            for (int i = 0; i < 5; i++)
            {
                nums[0, i] = contador++;

            }
            for (int i = 0; i < 5; i++)
            {
                nums[1, i] = contador++;
            }

            Console.Read();

            // Matrizes **********************************************************************************
            */

            /*
             int numAlunos = Console2.ReadInt("Insira o nº de estudantes");

             // Ler as notas dos estudantes

             int[] notas = new int[numAlunos];  // [0, 0, 0]
             Console.WriteLine("Insira todas as notas, carregando em Enter após cada uma delas");
             for (int i = 0; i <= notas.Length - 1; i++)
             {
                 notas[i] = Console2.ReadInt("");
             }
             int x = 0;

             // calcular a soma

             var soma = 0;
             for (int i = 0; i < notas.Length; i++)
             {
                 soma += notas[i];
             }
             int media = soma / numAlunos;

             // DRY → Don't Repeat Yourself
             // encontrar nota mínima

             int min = int.MaxValue;
             for (int i = 0; i < notas.Length; i++)
             {
                 if (notas[i] < min)
                 {
                     min = notas[i];
                 }
             }

             // encontrar nota máxima

             int max = int.MinValue;
             for (int i = 0; i < notas.Length; i++)
             {
                 if (notas[i] > max)
                 {
                     max = notas[i];
                 }
             }

             // - max e min numa única passagem

             max = int.MinValue;
             min = int.MaxValue;
             for (int i = 0; i < notas.Length; i++)
             {
                 if (notas[i] < min)
                     min = notas[i];
                 if (notas[i] > max)
                     max = notas[i];
             }

             // Mostrar todas as notas
             // Mostrar a Min, Max e Avg

             Console.WriteLine("Max {0}",max);
             Console.WriteLine("Min {0}",min);
             Console.WriteLine("Media {0}",media);*/
            Console.Read();
        }
    }
}

