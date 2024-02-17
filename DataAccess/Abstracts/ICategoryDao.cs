using System;
using Kodlama.ioWorkShopWeek2.Entities;

namespace Kodlama.ioWorkShopWeek2.DataAccess.Abstracts
{
	public interface ICategoryDao
	{
        void Add(Category category);
        void Delete(int categoryId);
        List<Category> GetAll();
        Category GetById(int id);
        void Update(int categoryId, Category updatedCategory);

    }
}

