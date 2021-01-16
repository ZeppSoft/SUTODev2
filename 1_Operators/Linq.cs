using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace _1_Operators
{

    class Student : IComparable<Student>
    {
        public string Name { get; set; }
        public string TeacherName { get; set; }
        public int Grade { get; set; }

        public int CompareTo([AllowNull] Student other)
        {
            if (other == null)
                return -1;

            return this.Grade - other.Grade;
        }
    }

    class Teacher
    {
        public string Name { get; set; }
        public int Experience { get; set; }
    }


    public static class Linq
    {

        public static void HomeWork()
        {
            var teachers = new List<Teacher>()
            {
                new Teacher {Name = "Max", Experience = 10},
                new Teacher {Name = "Vik", Experience = 15},
                new Teacher {Name = "Paul", Experience = 9}
            };

            var students = new List<Student>()
            {
                new Student { Name = "Ivan", TeacherName = "Vik",Grade = 5},
                new Student { Name = "Eugine", TeacherName = "Vik",Grade = 2},
                new Student { Name = "Marina", TeacherName = "Max",Grade = 3},
                new Student { Name = "Vitaly", TeacherName = "Max",Grade = 4},
                new Student { Name = "Oleg", TeacherName = "Vik",Grade = 5},
                new Student { Name = "Georgy", TeacherName = "Paul",Grade = 4},
                new Student { Name = "Artur", TeacherName = "Max",Grade = 3},
                new Student { Name = "Irina", TeacherName = "Paul",Grade = 5},
                new Student { Name = "Olga", TeacherName = "Max",Grade = 4},
            };



            //1. To select all student which have a grade more than 3
            /*
            var querySimple =
                from st in students
                //let gr = st.Grade > 3
                where st.Grade > 3
                select st; */

            /*  var querySimple = students.Where(x => x.Grade > 3);

              foreach (var el in querySimple)
              {
                  Console.WriteLine($"Student {el.Name}, Grade = {el.Grade}");
              }
            */

            //2. To select all students with their appropriate teachers as student`s name : teacher name(experience)
            /*var querySimple =
                from st in students
                join t in teachers on st.TeacherName equals t.Name
                select new {StudentName = st.Name, TeacherName = t.Name, TeacherExp = t.Experience};*/

            /* var querySimple = students.Join(teachers, st => st.TeacherName, t => t.Name,
                 (st, t) => new {StudentName = st.Name, TeacherName = t.Name, TeacherExp = t.Experience});

             foreach (var el in querySimple)
             {
                 Console.WriteLine($"{el.StudentName} , {el.TeacherName}, {el.TeacherExp}");
             }
            */

            //3. To select avg, max and min grades from all student
            //Avg = {students.Average(x=> x.Grade)}
            //, Min = {students.Min().Grade},


            //var m = students.Max().Grade;

            Console.WriteLine($"Max = {students.Max().Grade}, Min = {students.Min().Grade}, Avg = {students.Average(x=> x.Grade)}");




        }
        public static void SimpleFrom()
        {
            var array = new int []  {1,2,3,4 };
            string[] files = {"fileA.txt", "fileB.txt", "fileC.txt" };

            bool resAll = array.All(x => x > 2);
            bool resAny = array.Any(x => x > 2);

            Console.WriteLine($"resAll = {resAll}, resAny = {resAny}");

            //first variant pure LINQ
            // var query = from arrElement in array where arrElement % 2 == 0 select arrElement;

            //second variant: Extention method
            //var query = array.Where(x => x % 2 == 0);
            //var query = array.Select(x => x * 3);


            //1st variant
            //var query = array.OrderBy(x => x);
            //var query = array.OrderByDescending(x => x);

            //2nd variant
            //var query = from el in array orderby el select el; 


            //var query = array.Skip(3).Take(2);



           // Console.WriteLine(string.Join(", ",query.ToArray()));


            /*
            var exeptionDemoQuery =
                from file in files
                let n = SomeMethodWithException(file)
                select n;

            foreach (var el in exeptionDemoQuery) //the exception will occurs here when method will throws an InvalidOperationException
            {
                Console.WriteLine(el);
            }
            */
        }

        static string SomeMethodWithException(string s)
        {
            if (s[4] == 'C')
                throw new InvalidOperationException();
            return "New folder";
        }



    }
}
