using System;
using System.Diagnostics.Tracing;
using CourseControl.Entities;

namespace CourseControl
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<Courses> set = ReceberDados();

            HashSet<Users> user = new HashSet<Users>();

            foreach (Courses eachCourse in set)
            {
                foreach (Users eachuser in eachCourse.numbers)
                {
                    user.Add(eachuser);
                }
            }

            Console.WriteLine("\nTotal Students: " + user.Count);
        }

        static SortedSet<Courses> ReceberDados()
        {
            SortedSet<Courses> course1 = new SortedSet<Courses>();
            HashSet<Users> user1 = new HashSet<Users>();

            Console.Write("How many courses to add?: ");
            int courses = int.Parse(Console.ReadLine());

            for (int i = 1; i <= courses; i++)
            {
                Console.Write($"\nHow many students for course #{i}:");
                int students = int.Parse(Console.ReadLine());

                for (int j = 0; j < students; j++)
                {
                    int studentnum = int.Parse(Console.ReadLine());

                    user1.Add(new Users(studentnum));
                }
                course1.Add(new Courses(i, new HashSet<Users>(user1)));
            }
            return course1;
        }
    }
}