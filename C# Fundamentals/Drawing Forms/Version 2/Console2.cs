using System;


namespace School.SDK
{
    public class Console2
    {
        public static string ReadString(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static int ReadInt(string mensagem)
        {
            Console.WriteLine(mensagem);
            return int.Parse(Console.ReadLine());
        }

        public static bool ReadInt32(string message, out int res)
        {
            Console.WriteLine(message);
            string str = Console.ReadLine();

            return int.TryParse(str, out res);
        }

        public static int[] LerNotas(int numNotas)
        {

            int[] notas = new int[numNotas];
            Console.WriteLine("Insira todas as notas, carregando em Enter após cada uma delas");
            for (int i = 0; i <= notas.Length - 1; i++)
            {
                notas[i] = Console2.ReadInt("");
            }
            return notas;
        }
    }
    }

