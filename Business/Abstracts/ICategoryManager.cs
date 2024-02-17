using System;
using Kodlama.ioWorkShopWeek2.Entities;

namespace Kodlama.ioWorkShopWeek2.Business.Abstracts
{
	public interface ICategoryManager
	{
        void Add(Category category);
        void Delete(int categoryId);
        List<Category> GetAll();
        Category GetById(int id);
        void Update(int categoryId, Category updatedCategory);
    }
}

