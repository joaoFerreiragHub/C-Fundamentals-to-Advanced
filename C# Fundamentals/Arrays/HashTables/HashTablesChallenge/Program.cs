using System;
using System.Collections;

namespace HashTablesChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable table = new Hashtable();
            Student[] students = new Student[5];
            Student stud1 = new Student(1, "Maria", 98);
            Student stud2 = new Student(2, "Matt", 78);
            Student stud3 = new Student(1, "Mario", 68);
            Student stud4 = new Student(4, "Manson", 88);

            foreach(Student stud in students)
            { 
                if(!table.ContainsKey(stud.Id))
                {
                    table.Add(stud.Id, stud);
                    Console.WriteLine("Student was added", stud.Id);
                }
                else 
                {
                  Console.WriteLine("Cant have 2 students with same id");
                }
            }
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