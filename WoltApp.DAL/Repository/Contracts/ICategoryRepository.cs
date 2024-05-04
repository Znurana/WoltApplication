using System;
using WoltApp.DAL.Model;

namespace WoltApp.DAL.Repository.Contracts
{
	public interface ICategoryRepository
	{
        public Category Get(int id);
        public List<Category> GetList();
        public Category Add(Category item);
        public Category Update(int id, Category item);
        public Boolean Remove(int id);
    }
}

