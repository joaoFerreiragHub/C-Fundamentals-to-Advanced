using System;

namespace School.SDK
{
    public class Stats
    {
        public static int CalcularSoma(int[] notas)
        {
            var soma = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                soma += notas[i];
            }
            return soma;
        }

        public static int CalcularMedia(int[] notas)
        {
            return CalcularSoma(notas) / notas.Length;
        }

        public static int CalcularMin(int[] notas)
        {
            int min = int.MaxValue;
            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] < min)
                {
                    min = notas[i];
                }
            }
            return min;
        }
        public static int CalcularMax(int[] notas)
        {
            int max = int.MinValue;
            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] > max)
                {
                    max = notas[i];
                }
            }
            return max;
        }
        public static void MinMax(int[] notas, out int min, out int max)
        {
            max = int.MinValue;
            min = int.MaxValue;
            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] < min)
                    min = notas[i];
                if (notas[i] > max)
                    max = notas[i];
            }
        }

    }
}
