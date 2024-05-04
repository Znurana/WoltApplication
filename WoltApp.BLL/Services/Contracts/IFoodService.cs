using System;
using WoltApp.DAL.Dto;
using WoltApp.DAL.Model;

namespace WoltApp.BLL.Services.Contracts
{
	public interface IFoodService
	{
        public FoodDto Get(int id);
        public List<FoodDto> GetList();
        public FoodDto Add(FoodDto item);
        public FoodDto Update(int id, FoodDto item);
        public Boolean Remove(int id);
    }
}

