using System;
using WoltApp.DAL.Model.Enums;

namespace WoltApp.DAL.Model
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string City { get; set; } = "Baku";
        public int Rating { get; set; }
        public RestaurantType Type { get; set; }

        public List<Category> Categories { get; set; }

    }
}

