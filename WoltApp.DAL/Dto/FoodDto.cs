using System;
using WoltApp.DAL.Model;

namespace WoltApp.DAL.Dto
{
	public class FoodDto
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public string Ingredients { get; set; } 
        public int Rating { get; set; }
        public int CategoryId { get; set; }

    }
}

