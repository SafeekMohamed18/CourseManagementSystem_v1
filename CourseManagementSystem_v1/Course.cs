using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v1
{
    public class Course
    {
        private string courseId { get; set; }
        private string title { get; set; }
        private string Duration { get; set; }
        private decimal Price { get; set; }

        public string CourseId { get; set; }

        public Course(string courseId, string title, string duration, decimal price)
        {
            this.courseId = courseId;
            this.title = title;
            Duration = duration;
            Price = price;
        }

        public override string ToString()
        {
            return $"ID: {courseId}, Title: {title}, Duration: {Duration}, Price: {Price}";
        }
    }
    public class DigitalCourse : Course
    {
        public string CourseLink { get; set; }
        public string FileSize { get; set; }

        public DigitalCourse(string courseId, string title, string duration, decimal price, string courseLink, string fileSize) : base(courseId, title, duration, price)
        {
            CourseLink = courseLink;
            FileSize = fileSize;
        }
    }
    public class OnPremisCourse : Course
    {
        public string Schedule { get; set; }
        public string ClassroomCapacity { get; set; }
        public OnPremisCourse(string courseId, string title, string duration, decimal price, string schedule, string classroomCapacity) : base(courseId, title, duration, price)
        {
            Schedule = schedule;
            ClassroomCapacity = classroomCapacity;
        }



    }
}
