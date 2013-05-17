using System;
using System.Collections.Generic;

namespace InheritanceAndPolymorphism
{
    class CoursesExamples
    {
        static void Main()
        {
            IList<Student> students = new List<Student>()
            {
                new Student("Peter"),
                new Student("Maria")
            };
            LocalCourse localCourse = new LocalCourse("Databases",
                new Teacher("Svetlin Nakov"), students, "Enterprise");
            Console.WriteLine(localCourse);

            localCourse.Lab = "Enterprise";
            Console.WriteLine(localCourse);

            localCourse.Students = new List<Student>() { new Student("Peter"), new Student("Maria") };
            Console.WriteLine(localCourse);

            localCourse.TeacherName = new Teacher("Svetlin Nakov");
            localCourse.Students.Add(new Student("Milena"));
            localCourse.Students.Add(new Student("Todor"));
            Console.WriteLine(localCourse);

            OffsiteCourse offsiteCourse = new OffsiteCourse(
                "PHP and WordPress Development", new Teacher("Mario Peshev"),
                new List<Student>() { new Student("Thomas"), new Student("Ani"),
                    new Student("Steve") }, "Plovdiv");
            Console.WriteLine(offsiteCourse);
        }
    }
}
