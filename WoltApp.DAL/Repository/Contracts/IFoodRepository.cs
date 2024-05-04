using System;
using WoltApp.DAL.Model;

namespace WoltApp.DAL.Repository.Contracts
{
	public interface IFoodRepository
	{
		public Food Get(int id);
		public List<Food> GetList();
		public Food Add(Food item);
		public Food Update(int id, Food item);
		public Boolean Remove(int id);

		
	}
}

