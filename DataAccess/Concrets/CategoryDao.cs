using System;
using Kodlama.ioWorkShopWeek2.DataAccess.Abstracts;
using Kodlama.ioWorkShopWeek2.Entities;

namespace Kodlama.ioWorkShopWeek2.DataAccess.Concrets
{
    public class CategoryDao : ICategoryDao
    {
        List<Category> categories;

        public CategoryDao()
        {
            categories = new List<Category>();
            categories.Add(new Category(1, "Programlama"));
        }

        public void Add(Category category)
        {
            categories.Add(category);
        }

        public void Delete(int categoryId)
        {
            Category categoryToDelete = null;
            foreach (Category category in categories)
            {
                if (category.CategoryId == categoryId)
                {
                    categoryToDelete = category;
                    break;
                }
            }

            if (categoryToDelete != null)
            {
                categories.Remove(categoryToDelete);
                Console.WriteLine("Kategori başarıyla silindi.");
            }
            else
            {
                Console.WriteLine("Belirtilen ID'ye sahip bir kategori bulunamadı.");
            }
        }

        public List<Category> GetAll()
        {
            foreach (Category category1 in categories)
            {
                Console.WriteLine("Kategoriler listelendi: " + category1.CategoryName);
            }
            return categories;
        }

        public Category GetById(int id)
        {
            foreach (Category category in categories)
            {
                if (category.CategoryId == id)
                {
                    Console.WriteLine(category.CategoryName + " isimli kategori bulundu.");
                    return category; 
                }
            }
            return null;
        }

        public void Update(int categoryId, Category updatedCategory)
        {
            foreach (Category category in categories)
            {
                if (category.CategoryId == categoryId)
                {
                    category.CategoryName = updatedCategory.CategoryName;
                    Console.WriteLine("Kategori başarıyla güncellendi.");
                    return;
                }
            }
            Console.WriteLine("Belirtilen ID'ye sahip bir kategori bulunamadı.");
        }
    }
}

