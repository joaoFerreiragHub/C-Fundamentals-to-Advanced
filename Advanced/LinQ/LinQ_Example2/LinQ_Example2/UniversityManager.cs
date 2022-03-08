using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_Example2
{
    internal class UniversityManager
    {
        public List<University> universities;
        public List<Student> students;

        public UniversityManager()
        {
            universities = new List<University>();
            students = new List<Student>();

            universities.Add(new University { Id = 1, Name = "Yale"});
            universities.Add(new University { Id = 2, Name = "Beijing Tech" });

            students.Add(new Student { Id = 1, Name = "Carla", Gender = "Female", Age = 17, universityId = 1 });
            students.Add(new Student { Id = 2, Name = "Toni", Gender = "Male", Age = 21, universityId = 1 });
            students.Add(new Student { Id = 3, Name = "Leyla", Gender = "Female", Age = 19, universityId = 2 });
            students.Add(new Student { Id = 4, Name = "James", Gender = "Trans-gender", Age = 25, universityId = 2 });
            students.Add(new Student { Id = 5, Name = "Linda", Gender = "Female", Age = 22, universityId = 2 });

        }

        public void MaleStudents()
        {
            IEnumerable<Student> maleStudents = from student in students 
                                                where student.Gender == "Male" 
                                                select student;

            Console.WriteLine("Male - Students : ");

            foreach (var student in maleStudents)
            {
                student.Print();
            }
        }
        public void FemaleStudents()
        {
            IEnumerable<Student> femaleStudents = from student in students
                                                where student.Gender == "Female"
                                                select student;

            Console.WriteLine("Female - Students : ");

            foreach (var student in femaleStudents)
            {
                student.Print();
            }
        }

        public void SortStudent()
        {
            var sortedStudent = from student in students orderby student.Age select student;

            Console.WriteLine("Students sorted by Age:");

            foreach (Student student  in sortedStudent)
            {
                student.Print(); 
            }
        }
        public void AllStudentsFromBenjingTech()
        {
            IEnumerable<Student> bjiStudents = from student in students
                                               join university in universities on student
                                               .universityId equals university.Id
                                               where university.Name == "Beinjing Tech"
                                               select student;
            Console.WriteLine("Students from Benjing Tech");

            foreach (Student student in bjiStudents)
            {
                student.Print();
            }
        }

        public void AllStudentsFromAnyUni(int universityId)
        {
            IEnumerable<Student> myStudents = from student in students
                                               join university in universities on student
                                               .universityId equals university.Id
                                               where university.Id == universityId
                                               select student;

            Console.WriteLine("Students from that uni {0}", universityId);

            foreach (Student student in myStudents)
            {
                student.Print();
            }
        }

        public void StudentAndUniverSityNameCollection()
        {
            var newCollection = from student in students
                                 join university in universities on student.universityId equals university.Id
                                 orderby student.Name
                                 select new { StudentName = student.Name, UniversityName = university.Name };

            Console.WriteLine("New Collection : ");

            foreach (var col in newCollection)
            {
                Console.WriteLine("Student {0} from Univertsity {1}", col.StudentName, col.UniversityName);
            }
        }
    } 
}
