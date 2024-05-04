using System;
using Microsoft.EntityFrameworkCore;
using WoltApp.DAL.Data;
using WoltApp.DAL.Model;
using WoltApp.DAL.Repository.Contracts;

namespace WoltApp.DAL.Repository
{
	public class CategoryRepository: ICategoryRepository
    {
        private readonly WoltDbContext _dbcontext;

        public CategoryRepository(WoltDbContext context)
        {
            this._dbcontext = context;
        }

        public Category Add(Category item)
        {
            var newItem = _dbcontext.Categories.Add(item);
            _dbcontext.SaveChanges();
            return newItem.Entity;
        }

       

        public Category Get(int id)
        {
            var item = _dbcontext.Categories.Where(x => x.Id == id).FirstOrDefault();
            return item;
        }

        public List<Category> GetList()
        {
            var items = _dbcontext.Categories.ToList();
            return items;
        }

        public bool Remove(int id)
        {
            var item = _dbcontext.Categories.Where(x => x.Id == id).FirstOrDefault();
            _dbcontext.Categories.Remove(item);
            _dbcontext.SaveChanges();
            return true;
        }

        public Category Update(int id, Category item)
        {
            var dbItem = _dbcontext.Categories.Where(x => x.Id == id).FirstOrDefault();
            dbItem.Name = item.Name;
            _dbcontext.Categories.Update(dbItem);
            _dbcontext.SaveChanges();
            return dbItem;
        }
    }
}

