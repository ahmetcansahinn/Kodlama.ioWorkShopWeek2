using System;
using Kodlama.ioWorkShopWeek2.Business.Abstracts;
using Kodlama.ioWorkShopWeek2.DataAccess.Abstracts;
using Kodlama.ioWorkShopWeek2.DataAccess.Concrets;
using Kodlama.ioWorkShopWeek2.Entities;

namespace Kodlama.ioWorkShopWeek2.Business.Concrets
{
	public class InstructorManager : IInstructorManager
	{
        private readonly IInstructorDao _instructorDao;
		public InstructorManager()
		{
		}

        public InstructorManager(IInstructorDao instructorDao)
        {
            _instructorDao = instructorDao;
        }

        public void Add(Instructor instructor)
        {
            _instructorDao.Add(instructor);
            if (instructor.InstructorId == 0)
            {
                Console.WriteLine("0 numaralı id girilemez.");
            }
        }

        public void Delete(int instructorId)
        {
            _instructorDao.Delete(instructorId);
        }

        public List<Instructor> GetAll()
        {
            _instructorDao.GetAll();
            return null;
        }

        public Instructor GetById(int id)
        {
            _instructorDao.GetById(id);
            if (GetById == null)
            {
                Console.WriteLine("Lütfen geçerli bir id giriniz.");
            }
            return null;
        }

        public void Update(int instructorId, Instructor updatedInstructor)
        {
            _instructorDao.Update(instructorId, updatedInstructor);
            

        }
    }
}

