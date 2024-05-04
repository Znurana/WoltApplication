using System;
using System.Text.Json.Serialization;
using WoltApp.DAL.Model;
using WoltApp.DAL.Model.Enums;

namespace WoltApp.DAL.Dto
{
	public class RestaurantDto
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string City { get; set; } = "Baku";

        [JsonIgnore]
        public int Rating { get; set; }
        public RestaurantType Type { get; set; }

    }
}

