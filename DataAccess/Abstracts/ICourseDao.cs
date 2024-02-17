using System;
using Kodlama.ioWorkShopWeek2.Entities;

namespace Kodlama.ioWorkShopWeek2.DataAccess.Abstracts
{
	public interface ICourseDao
	{
		void Add(Course course);
		void Delete(int courseId);
		List<Course> GetAll();
		Course GetById(int id);
		void Update(int courseId, Course updatedCourse);

	}
}

