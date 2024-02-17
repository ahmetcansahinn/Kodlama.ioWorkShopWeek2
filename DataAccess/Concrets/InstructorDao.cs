using System;
using Kodlama.ioWorkShopWeek2.DataAccess.Abstracts;
using Kodlama.ioWorkShopWeek2.Entities;

namespace Kodlama.ioWorkShopWeek2.DataAccess.Concrets
{
	public class InstructorDao : IInstructorDao
	{
        List<Instructor> instructors;
		public InstructorDao()
		{
            instructors = new List<Instructor>();

            instructors.Add(new Instructor(1, "Engin Demiroğ"));
            instructors.Add(new Instructor(2, "Halit Enes Kalaycı"));
		}

        public void Add(Instructor instructor)
        {
            instructors.Add(instructor);
        }

        public void Delete(int instructorId)
        {
            Instructor instructorToDelete = null;
            foreach (Instructor instructor in instructors)
            {
                if (instructor.InstructorId == instructorId)
                {
                    instructorToDelete = instructor;
                    break; // Silinecek eğitmen bulunduğunda döngüyü sonlandır
                }
            }

            if (instructorToDelete != null)
            {
                instructors.Remove(instructorToDelete);
                Console.WriteLine("Eğitmen başarıyla silindi.");
            }
            else
            {
                Console.WriteLine("Belirtilen ID'ye sahip bir eğitmen bulunamadı.");
            }
        }
        public List<Instructor> GetAll()
        {
            foreach(Instructor instructor in instructors)
            {
                Console.WriteLine("Eğitmenler listelendi: " +  instructor.InstructorName);
            }
            return instructors;
        }

        public Instructor GetById(int id)
        {
            foreach(Instructor instructor in instructors)
            {
                if (instructor.InstructorId == id)
                {
                    Console.WriteLine(instructor.InstructorName + " isimli eğitmen bulundu");
                        
                }
            }
            return null;
        }

        public void Update(int instructorId, Instructor updatedInstructor)
        {
            foreach (Instructor instructor in instructors)
            {
                if (instructor.InstructorId == instructorId)
                {
                    instructor.InstructorName = updatedInstructor.InstructorName;
                    Console.WriteLine("Eğitmen başarıyla güncellendi.");
                    return;
                }
            }
            Console.WriteLine("Belirtilen ID'ye sahip bir eğitmen bulunamadı.");
        }
    }
}

