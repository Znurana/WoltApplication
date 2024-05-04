using System;
namespace WoltApp.DAL.Model
{
	public class Category
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }

        public List<Food> Foods { get; set; }

    }
}

