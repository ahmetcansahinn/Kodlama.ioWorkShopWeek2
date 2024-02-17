using System;
using Kodlama.ioWorkShopWeek2.Business.Abstracts;
using Kodlama.ioWorkShopWeek2.DataAccess.Abstracts;
using Kodlama.ioWorkShopWeek2.DataAccess.Concrets;
using Kodlama.ioWorkShopWeek2.Entities;

namespace Kodlama.ioWorkShopWeek2.Business.Concrets
{
    public class CourseManager : ICourseManager
    {
        private readonly ICourseDao _courseDao;

        public CourseManager(ICourseDao courseDao)
        {
            _courseDao = courseDao;
        }

        public void Add(Course course)
        {
            _courseDao.Add(course);
            if (course.CourseId == 0)
            {
                Console.WriteLine("0 numaralı id girilemez.");
            }
        }

        public void Delete(int courseId)
        {
            _courseDao.Delete(courseId);
        }

        public List<Course> GetAll()
        {
            _courseDao.GetAll();
            return null;
        }

        public Course GetById(int id)
        {
            _courseDao.GetById(id);
            if (GetById == null)
            {
                Console.WriteLine("Lütfen geçerli bir id giriniz.");
            }
            return null;
        }

        public void Update(int courseId, Course updatedCourse)
        {
            _courseDao.Update(courseId, updatedCourse);
        }
    }
}

