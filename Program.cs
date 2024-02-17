using Kodlama.ioWorkShopWeek2.Business.Concrets;
using Kodlama.ioWorkShopWeek2.DataAccess.Concrets;
using Kodlama.ioWorkShopWeek2.Entities;



CategoryManager categoryManager = new CategoryManager(new CategoryDao());
CourseManager courseManager = new CourseManager(new CourseDao());
InstructorManager instructorManager = new InstructorManager(new InstructorDao());

Console.WriteLine("Kategoriye ait işlemler: ");
categoryManager.GetAll();
categoryManager.GetById(1);
categoryManager.GetAll();
Category updatedCategory = new Category(1, "Yeni Programlama Kategorisi");
categoryManager.Update(1, updatedCategory);
Console.WriteLine("Güncellemden sonra Kategori Listesi");
categoryManager.GetAll();
categoryManager.Delete(1);

//Add metod kullanımı Dao içerisinde kullanılmıştır.
Console.WriteLine("-----------------------------------------");

Console.WriteLine("Kurslara ait işlemler: ");
courseManager.GetAll();
courseManager.GetById(2);
courseManager.Delete(1);
Course updatedCourse = new Course(3, "Senior Java Kampı");
courseManager.Update(3, updatedCourse);
Console.WriteLine("Silinen ve güncellenen kurslardan sonra güncel liste hali: ");
courseManager.GetAll();
//Add metod kullanımı Dao içerisinde kullanılmıştır.
Console.WriteLine("-----------------------------------------");


Console.WriteLine("Eğitmenlere ait işlemler: ");
instructorManager.GetAll();
instructorManager.GetById(1);
Instructor updatedInstructor = new Instructor(2, "Halit Kalaycı");
instructorManager.Update(1, updatedInstructor);
instructorManager.Delete(1);
Console.WriteLine("Silinen ve güncellenen eğitmenler sonrası güncel liste hali: ");
instructorManager.GetAll();
//Add metod kullanımı Dao içerisinde kullanılmıştır.







