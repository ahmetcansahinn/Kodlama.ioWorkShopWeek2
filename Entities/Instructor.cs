using System;
namespace Kodlama.ioWorkShopWeek2.Entities
{
	public class Instructor
	{
        public Instructor(int instructorId, string instructorName)
        {
            InstructorId = instructorId;
            InstructorName = instructorName;
        }

        public int InstructorId { get; set; }
        public string InstructorName { get; set; }
    }
}

