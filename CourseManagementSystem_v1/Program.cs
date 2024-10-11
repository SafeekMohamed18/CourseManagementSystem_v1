using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var courseManager = new CourseManager();
            bool exit = false;
            while (!exit)

            {
                Console.Clear();
                Console.WriteLine("Course Management System:");
                Console.WriteLine("1.Add a Course");
                Console.WriteLine("2.View All Courses");
                Console.WriteLine("3.Update a Course");
                Console.WriteLine("4. delete");
                Console.WriteLine("5.Exit");
                Console.WriteLine("Choose an option:");

                var option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        courseManager.CreateCourse();
                        break;
                    case "2":
                        courseManager.ReadCourses();
                        break;
                    case "3":
                        courseManager.UpdateCourse();
                        break;
                    case "4":
                        courseManager.DeleteCourse();
                        break;
                    case "5":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("enter vaild option");
                        break;
                }
            }

        }
    }
}
