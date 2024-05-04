using System;
using AutoMapper;
using WoltApp.DAL.Dto;
using WoltApp.DAL.Model;

namespace WoltApp.BLL.Mapping
{
	public class CustomMap:Profile
	{

		public CustomMap()
		{
			CreateMap<Restaurant, RestaurantDto>().ReverseMap();
			CreateMap<Food, FoodDto>().ReverseMap();
			CreateMap<Category, CategoryDto>().ReverseMap();
		}
	}
}

