using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feature
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student[] highSchoolStudents = new Student[]
            //{
            //    new Student { Id = 1, Name = "Duran" },
            //    new Student { Id = 2, Name = "Sky" }
            //};

            //List<Student> universityStudent = new List<Student>
            //{
            //    new Student { Id =3, Name = "Benson"}
            //};

            //foreach (var person in highSchoolStudents)
            //{
            //    Console.WriteLine(person.Name);
            //}



            IEnumerable<Student> highSchoolStudents = new Student[]
            {
                new Student { Id = 1, Name = "Duran" },
                new Student { Id = 2, Name = "Sky" }
            };

            IEnumerable<Student> universityStudent = new List<Student>
            {
                new Student { Id =3, Name = "Benson"}
            };

            //Console.WriteLine(highSchoolStudents.Count());

            IEnumerator<Student> enumerator = highSchoolStudents.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current.Name);
            }


            //foreach (var person in highSchoolStudents.Where(FilterMethod))
            //{
            //    Console.WriteLine(person.Name);
            //}

            //foreach (var person in highSchoolStudents.Where(
            //    delegate (Student student) 
            //    {
            //        return student.Name.StartsWith("D");
            //    }))
            //{
            //    Console.WriteLine(person.Name);
            //}

            foreach (var person in highSchoolStudents.Where(x => x.Name.StartsWith("D")))
            {
                Console.WriteLine(person.Name);
            }
        }

        private static bool FilterMethod(Student student)
        {
            return student.Name.StartsWith("D");
        }
    }
}
