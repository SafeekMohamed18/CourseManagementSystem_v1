using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v1
{
    public class CourseManager
    {
        public List<Course> courses = new List<Course>();

        //add course
        public void CreateCourse()
        {
            Console.WriteLine("Enter Course ID : ");
            string courseId = (Console.ReadLine() ?? "1");
            Console.WriteLine("Enter Course Title: ");
            string title = (Console.ReadLine() ?? "");
            Console.WriteLine("Enter Course Duration: ");
            string duration = (Console.ReadLine() ?? "");
            Console.WriteLine("Enter Course price: ");
            decimal price = decimal.Parse(Console.ReadLine() ?? "1");

            var course = new Course(courseId, title, duration, price);


            courses.Add(course);
            Console.WriteLine("Course added successfully.");

        }
        public void ReadCourses()
        {
            if (courses.Count == 0)
            {
                Console.WriteLine(" no courses available at the moment");
                return;
            }
            else
            {
                Console.WriteLine("List of Courses:");
                foreach (var item in courses)
                {
                    Console.WriteLine(item);
                }

            }
        }
        public void UpdateCourse()
        {
            Console.WriteLine("Enter the Course ID to update: ");
            string id =(Console.ReadLine() ?? "");

            var upcourse = courses.SingleOrDefault(c => c.CourseId == id);
            if (upcourse != null)
            {
                Console.WriteLine("Enter new Title: ");
                string uTitle = (Console.ReadLine() ?? "");
                Console.WriteLine("Enter new Duration: ");
                string uDuration = (Console.ReadLine() ?? "");
                Console.WriteLine("Enter new Price: ");
                decimal uPrice = decimal.Parse(Console.ReadLine() ?? "1");
                Console.WriteLine("Course updated successfully.");

                courses.Add( upcourse);
            }
            else
            {
                Console.WriteLine("no course fount");
            }
        }
        public void DeleteCourse()
        {
            Console.WriteLine("Enter the Course ID to delete: ");
            string id = (Console.ReadLine() ?? "");
            var dcourse = courses.SingleOrDefault(c => c.CourseId == id);
            if (dcourse != null)
            {
                courses.Remove(dcourse);
                Console.WriteLine("Course deleted successfully.");
            }
            else
            {
                Console.WriteLine("no data fount");
            }
        }
         private void ValitateCourePrice(decimal Price)
        {
            while ( Price <= 0)
            {
                Console.WriteLine("Error : Enter a valid Price");
                Price = decimal.Parse(Console.ReadLine() ?? "0");
            }
        }

    }
}
