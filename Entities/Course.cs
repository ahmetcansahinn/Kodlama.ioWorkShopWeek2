using System;
namespace Kodlama.ioWorkShopWeek2.Entities
{
	public class Course
	{
        public Course(int courseId, string courseName)
        {
            CourseId = courseId;
            CourseName = courseName;
        }

        public int CourseId { get; set; }
        public string CourseName { get; set; }
	}
}

