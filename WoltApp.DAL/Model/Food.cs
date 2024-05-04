using System;
namespace WoltApp.DAL.Model
{
    public class Food
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public string Ingredients { get; set; } //List or string
        public int Rating { get; set; }
        public bool IsActive { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public List<FeedBack> FeedBacks { get; set; }


      
    }
}

