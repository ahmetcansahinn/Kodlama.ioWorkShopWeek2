using System;
using Kodlama.ioWorkShopWeek2.Business.Abstracts;
using Kodlama.ioWorkShopWeek2.DataAccess.Abstracts;
using Kodlama.ioWorkShopWeek2.DataAccess.Concrets;
using Kodlama.ioWorkShopWeek2.Entities;

namespace Kodlama.ioWorkShopWeek2.Business.Concrets
{
	public class CategoryManager: ICategoryManager
	{
        private readonly ICategoryDao _categoryDao;
		public CategoryManager()
		{
		}

        public CategoryManager(ICategoryDao categoryDao)
        {
            _categoryDao = categoryDao;
        }

        public void Add(Category category)
        {
            _categoryDao.Add(category);
            if (category.CategoryId == 0)
            {
                Console.WriteLine("0 numaralı id girilemez.");
            }
        }

        public void Delete(int categoryId)
        {
            _categoryDao.Delete(categoryId);
        }

        public List<Category> GetAll()
        {
            _categoryDao.GetAll();
            return null;
        }

        public Category GetById(int id)
        {
            _categoryDao.GetById(id);
            if (GetById == null)
            {
                Console.WriteLine("Lütfen geçerli bir id giriniz.");
            }
            return null;
        }

        public void Update(int categoryId, Category updatedCategory)
        {
            _categoryDao.Update(categoryId, updatedCategory);
        }
    }
}

