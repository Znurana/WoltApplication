using System;
namespace WoltApp.DAL.Model
{
    public class OrderLine
    {

        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int FoodId { get; set; }
        public Food Food { get; set; }

    }
}

