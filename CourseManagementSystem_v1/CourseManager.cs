using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v1
{
    internal class CourseManager
    {
        private List<Course> courses = new List<Course>();

        //add course
        public void CreateCourse()
        {
            Console.WriteLine("Enter course Id for add a course: ");
            string id =(Console.ReadLine()??"1");
            Console.WriteLine("enter course title for the course: ");
            string title =(Console.ReadLine()??"");
            Console.WriteLine("enter a duration for a course: ");
            string duration = (Console.ReadLine() ?? "");
            Console.WriteLine();
        }

    }
}
