using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionariez
{
    class Program
    {
        // key - value
        // Auto - car
        static void Main(string[] args)
        {
            //Dictionary<TKey, TValue>

            // Array de empregados de tipo Empregado
            Employee[] employees = {
                new Employee ("CEO","Gwyn",95,200),
                new Employee ( "Manager", "Gwyn", 35, 25),
                new Employee ( "HR", "Gwyn", 32, 21 ),
                new Employee ( "Secretary", "Gwyn", 28, 18 ),
                new Employee ( "Lead Developer", "Gwyn", 55, 35 ),
                new Employee ( "Intern", "Gwyn", 22, 8 )
            };

            Dictionary<int, string> myDictionary = new Dictionary<int, string>()
            {
                {1,"one"},
                {2,"two"},
                {3,"three"}
            };

            // Dicionario/repositorio de funcionarios
            Dictionary<string, Employee> employeesDirectory = new Dictionary<string, Employee>();

            //Adiciona a cada empregado no repositorio a sua Role
            foreach(Employee emp in employees)
            {
                employeesDirectory.Add(emp.Role, emp);
            }

            // Mostra o valor da key em inteiro(Index) mesmo esta estando representada como string
            for (int i=0; 1 < employeesDirectory.Count; i++)
            {
                KeyValuePair<string, Employee> keyValuePair = employeesDirectory.ElementAt(i);
                Console.WriteLine("Value Retrieved!.", keyValuePair.Key);

                Employee employeeValue = keyValuePair.Value;

                Console.WriteLine("Employee Name: {0}.", employeeValue.Name);
                Console.WriteLine("Employee Role: {0}.", employeeValue.Role);
                Console.WriteLine("Employee Age: {0}.", employeeValue.Age);
                Console.WriteLine("Employee Salary: {0}.", employeeValue.Rate);
            }
            //Fazer update a uma entrada

            string KeyToUpdate = "HR";
            if(employeesDirectory.ContainsKey(KeyToUpdate))
            {
                employeesDirectory[KeyToUpdate] = new Employee("HR", "Jill", 32, 21);
                Console.WriteLine("Employee with Role/key {0} was updated",KeyToUpdate);
            }
            else
            {
                Console.WriteLine("No employee found with this key", KeyToUpdate);
            }

            //remove an item
            string RemoveAnEntry = "Intern";
            if (employeesDirectory.Remove(RemoveAnEntry))
            {
                Console.WriteLine("Employee with Role/key {0} was removed",RemoveAnEntry);
            }
            else
            {
                Console.WriteLine("No employee found with this key", KeyToUpdate);
            }

            // caso ja exista a key CEO v1.0
            string key = "CEO";
            if(employeesDirectory.ContainsKey(key))
            {
                Employee emp1 = employeesDirectory[key];
                Console.WriteLine("name {0} Role {1} Salary {3}", emp1.Name, emp1.Role, emp1.Salary);

            }
            else
            {
                Console.WriteLine("Key not found");
            }

            // caso ja exista a key CEO v2.0
            Employee result = null;
            if(employeesDirectory.TryGetValue("Intern",out result))
            {
                Console.WriteLine("Value Retrieved!.");
                Console.WriteLine("Employee Name: {0}.", result.Name);
                Console.WriteLine("Employee Role: {0}.",result.Role);
                Console.WriteLine("Employee Age: {0}.",result.Age);
                Console.WriteLine("Employee Salary: {0}.",result.Rate);
            }
            else
            {
                Console.WriteLine("Key not found",key);
            }


        }

        class Employee
        {
            public string Role { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public int Rate { get; set; }

            public float Salary
            {
                get 
                {
                    return Rate * 8 * 5 * 4 * 12;
                } 
            }

            public Employee(string role, string name, int age, int rate)
            {
                this.Role = role;
                this.Name = name;
                this.Age = age;
                this.Rate = rate;
            }
        }
    }
}
