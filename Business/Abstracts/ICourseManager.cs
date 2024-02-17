using System;
using Kodlama.ioWorkShopWeek2.Entities;

namespace Kodlama.ioWorkShopWeek2.Business.Abstracts
{
	public interface ICourseManager
	{
        void Add(Course course);
        void Delete(int courseId);
        List<Course> GetAll();
        Course GetById(int id);
        void Update(int courseId, Course updatedCourse);

    }
}

