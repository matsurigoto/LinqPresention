using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Feature.CustemLinq;

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

            // List 與 Array 皆透過 IEnumerable 實作，所以具有 GetEnumerator 方法
            // highSchoolStudents.GetEnumerator();
            // universityStudent.GetEnumerator();

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

            IEnumerator<Student> enumerator = highSchoolStudents.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current.Name);
            }


            //擴充方法 CustomLinq
            Console.WriteLine(highSchoolStudents.Count());




            //----------- 方法名稱、匿名方法、Lambda ---------

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

            //foreach (var person in highSchoolStudents.Where(x => x.Name.StartsWith("D")))
            //{
            //    Console.WriteLine(person.Name);
            //}
        }

        private static bool FilterMethod(Student student)
        {
            return student.Name.StartsWith("D");
        }
    }
}
