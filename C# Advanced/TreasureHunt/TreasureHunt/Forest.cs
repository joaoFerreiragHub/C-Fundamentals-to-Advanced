using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreasureHunt.Interface;

namespace TreasureHunt
{
    public class Forest : IElement
    {
      
       //terreno -> wall -> tesouro(Aleatorio) -> carros

        static string[,] MapForest =
            {
                { "1","2","3","4"},
                { "5","6","7","8"},
                { "9","10","11","12"},
                { "13","14","15","16"},

            };

        public void Color()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            Console.Clear();
            for (int i = 0; i < MapForest.GetLength(0); i++)
            {
                for (int j = 0; j < MapForest.GetLength(1); j++)
                {
                    Console.Write(MapForest[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void Simbol()
        {
            throw new NotImplementedException();
        }
    }
}
