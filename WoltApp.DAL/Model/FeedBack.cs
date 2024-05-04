using System;
namespace WoltApp.DAL.Model
{
    public class FeedBack
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public string Comment { get; set; }
        public DateTime CommentDate { get; set; }

        public int FoodId { get; set; }
        public Food Food { get; set; }
    }
}

