using System;

namespace School.App
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
    }
    }

