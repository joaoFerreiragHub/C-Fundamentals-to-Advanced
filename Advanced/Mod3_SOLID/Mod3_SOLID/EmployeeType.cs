using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3_SOLID
{
    public class EmployeeType : Employee
    {
        public EmployeeType(string name) : base(name)
        {
        }

        public EmployeeType Type { get; set; }
        public string Path => "employees.json";

        double[,] _taxes = new double[,]
        {
                {0, 7091, 0.145, 0},
                {7091, 10700, .23, 602.74},
                {10700, 20261, .285, 1191.24},
                {20261, 25000, .35, 2508.2},
                {25000, 36856, .37, 3008.2},
                {36856, 80640, .45, 5956.68},
                {80640, double.MaxValue, .48, 8375.88}
        };

        public double[,] Get_taxes()
        {
            return _taxes;
        }

        public decimal ComputeAnnualNetSalary(double[,] _taxes)
        {
            return (decimal)_taxes[0,0];
        }
        public void SaveToFile() { }
        public void SaveToDatabase() { }
        private  decimal GetTax(decimal annualSalary)
        {
            return annualSalary = Convert.ToDecimal(annualSalary);
        }
    }
}
