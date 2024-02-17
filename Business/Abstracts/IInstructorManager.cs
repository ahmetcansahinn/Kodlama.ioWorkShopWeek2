using System;
using Kodlama.ioWorkShopWeek2.Entities;

namespace Kodlama.ioWorkShopWeek2.Business.Abstracts
{
	public interface IInstructorManager
	{
        void Add(Instructor instructor);
        void Delete(int instructorId);
        List<Instructor> GetAll();
        Instructor GetById(int id);
        void Update(int instructorId, Instructor updatedInstructor);
    }
}

