using System;
using WoltApp.DAL.Data;
using WoltApp.DAL.Model;
using WoltApp.DAL.Repository.Contracts;

namespace WoltApp.DAL.Repository
{
    public class FoodRepository : IFoodRepository
    {
        private readonly WoltDbContext _dbcontext;

        public FoodRepository(WoltDbContext context)
        {
            this._dbcontext = context;
        }

        public Food Add(Food item)
        {
            var newItem = _dbcontext.Foods.Add(item);
            _dbcontext.SaveChanges();
            return newItem.Entity;

        }

        public Food Get(int id)
        {
            var item = _dbcontext.Foods.Where(x => x.Id == id).FirstOrDefault();
            return item;
        }

        public List<Food> GetList()
        {
            var items = _dbcontext.Foods.ToList();
            return items;
        }

        public bool Remove(int id)
        {
            var item = _dbcontext.Foods.Where(x => x.Id == id).FirstOrDefault();
            _dbcontext.Foods.Remove(item);
            _dbcontext.SaveChanges();
            return true;
        }

        public Food Update(int id, Food item)
        {
            var dbItem = _dbcontext.Foods.Where(x => x.Id == id).FirstOrDefault();
            dbItem.Name = item.Name;
            dbItem.Price = item.Price;
            _dbcontext.Foods.Update(dbItem);
            _dbcontext.SaveChanges();
            return dbItem;


        }
    }
}

