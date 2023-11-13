using EfCoreResult.Data;
using EfCoreResult.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EfCoreResults
{
    public class Start
    {

        public static void Main(string[] args)
        {
            SchoolContext context = new SchoolContext();

            //createFakeData(context);

            //List<DeveloperStudio> developers = createFakeData();

            //context.DeveloperStudios.AddRange(developers);

            //List<Student> students = context.Students.Where(s => s.Classyear == "7b").ToList();

            //foreach (Student student in students)
            //{
            //    Console.WriteLine(student.Name);
            //}

            //List<Teacher> teachers = context.Teachers.ToList();

            //foreach (Teacher teacher in teachers)
            //{
            //    teacher.Salary *= 1.05;
            //}

            //Course course = new Course { Subject = "Retortik", Duration = 180 };

            //List<Student> students1 = context.Students.Where(s => s.Name.StartsWith("J")).ToList();

            //foreach (Student student in students1)
            //{
            //    student.Courses.Add(course);
            //}

            context.SaveChanges();

        }

        static void createFakeData(SchoolContext db)
        {
            //Teacher t1 = new Professor { Name = "David", Lastname = "Müller", Age = 37, Salary = 60.122, Titel = "Prof" };
            //Teacher t2 = new Tutor { Name = "Lisa", Lastname = "Lotte", Age = 46, Salary = 79.000,  LearnGroup = "C#" };

            //Classroom c1 = new Classroom { Name = "R305", Seates = 30, Teacher = t2 };
            //Classroom c2 = new Classroom { Name = "B405", Seates = 55, Teacher = t1 };

            //Course cu1 = new Course { Subject = "Ef-Core Basics", Duration = 120};
            //Course cu2 = new Course { Subject = "Autotunning leicht gemacht", Duration = 180}; ;

            //Student s1 = new Student { Name = "Jannik", LastName = "Weber", BirthDate = new DateTime(), Classroom = c1, Classyear = "7b" };
            //Student s2 = new Student { Name = "Jassin", LastName = "Ahmed", BirthDate = new DateTime(), Classroom = c2, Classyear = "7a" };
            //Student s3 = new Student { Name = "Selin", LastName = "Schreiner", BirthDate = new DateTime(), Classroom = c1, Classyear = "7b" };
            //Student s4 = new Student { Name = "Hendrik", LastName = "Büchner", BirthDate = new DateTime(), Classroom = c2, Classyear = "7a" };
            //Student s5 = new Student { Name = "Niklas", LastName = "Mosser", BirthDate = new DateTime(), Classroom = c1, Classyear = "7b" };
            //Student s6 = new Student { Name = "Katrin", LastName = "Zisterer", BirthDate = new DateTime(), Classroom = c2, Classyear = "7a" };

            //cu1.Students = new Student[] { s1, s3, s5 };
            //cu2.Students = new Student[] { s2, s4, s6 };

            //db.Add(cu1);
            //db.Add(cu2);

            db.SaveChanges();
        }
    }
}
