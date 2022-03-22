using System;

namespace Aula11
{
    class Program
    {

        // quantos alunos
        // ler notas
        // calcular media
        // encontrar minima, maxima
        // mostrar todas as notas
        // mostrar min, max e avg
        
        static void Main(string[] args)
        {

            Console.WriteLine("Qual é o nº de alunos?");
            int students = int.Parse(Console.ReadLine());

            int[] listNotas = new int[students];

            int soma = 0;

            for (int i = 0; i < listNotas.Length; i++)
            {
                Console.WriteLine("Insira as notas");
                listNotas[i] = int.Parse(Console.ReadLine());
                soma = soma + listNotas[i];
            }

            int maximo = int.MinValue;
            for (int j = 0; j < listNotas.Length; j++)
            {
                
                if (listNotas[j] > maximo)
                    maximo = listNotas[j];
                
            }
            Console.WriteLine("o maior é {0}", maximo);

            int minimo = int.MaxValue;
            for (int k = 0; k < listNotas.Length; k++)
            {

                if (listNotas[k] < minimo)
                    minimo = listNotas[k];
                
            }


            /*int minimo = int.MaxValue;
            int maximo = int.MinValue;
            for (int j = 0; j < listNotas.Length; j++)
            {

                if (listNotas[j] > maximo)
                    maximo = listNotas[j];

                if (listNotas[k] < minimo)
                    minimo = listNotas[k];

            }*/

            Console.WriteLine("o maior é {0}", maximo);
            Console.WriteLine("o menor é {0}", minimo);

            double media = soma / students;
            Console.WriteLine("A media é {0}:",media);


            Console.Read();
        }


    }
}
