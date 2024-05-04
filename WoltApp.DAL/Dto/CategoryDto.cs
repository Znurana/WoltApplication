using System;
using WoltApp.DAL.Model;

namespace WoltApp.DAL.Dto
{
	public class CategoryDto
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public int RestaurantId { get; set; }
        //public Restaurant Restaurant { get; set; }

        //public List<Food> Foods { get; set; }


   
    }
}

