using System;
using Kodlama.ioWorkShopWeek2.Entities;

namespace Kodlama.ioWorkShopWeek2.DataAccess.Abstracts
{
	public interface IInstructorDao
	{
        void Add(Instructor instructor);
        void Delete(int instructorId);
        List<Instructor> GetAll();
        Instructor GetById(int id);
        void Update(int instructorId, Instructor updatedInstructor);
    }
}

