using System;
using System.Collections;

namespace Hashtabless
{
    class Program
    {
        //key - value
        //Auto - car
        static void Main(string[] args)
        {
            // Criar Hastable
            Hashtable table = new Hashtable();

            // Criar alunos do tipo (objeto) Alunos
            Student stud1 = new Student(1, "Maria", 98);
            Student stud2 = new Student(2, "Matt", 78);
            Student stud3 = new Student(3, "Mario", 68);
            Student stud4 = new Student(4, "Manson", 88);

            //Adicionar alunos a Hashtable
            table.Add(stud1.Id, stud1);
            table.Add(stud2.Id, stud2);
            table.Add(stud3.Id, stud3);
            table.Add(stud4.Id, stud4);

            // retirar os dados individuais na Hashtable
            Student storedStudent1 = (Student)table[stud1.Id];

            // retirar todos os dados da Hashtable


            // Versão simplificada
            foreach (Student value in table.Values)
            {
                Console.WriteLine("Student ID: {0}", value.Id);
                Console.WriteLine("Name: {0}", value.Name);
                Console.WriteLine("GPA: {0}", value.GPA);
            }

            Console.WriteLine("Student ID: {0}, Name: {1}, GPA{2}", storedStudent1.Id, storedStudent1.Name, storedStudent1.GPA);
        }


    }
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }
        public Student(int id, string name, float gpa)
        {

            this.Id = id;
            this.Name = name;
            this.GPA = gpa;
        }
    }
}
