using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPC_calc
{
    public class Calculator
    {
        public double AreaCirculo(double r)
            => 3.14 * Math.Pow(r, 2);

        public double AreaRectangle(double l, double w)
            => l * w;

        public List<double> SumarACollection(double n, List<double> collection)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                collection[i] += n;
            }

            return collection;
        }

        public int Multiply(params int[] inputs)
        {
            var res = 1;
            foreach (var input in inputs)
                res *= input;

            return res;
        }
    }
}
