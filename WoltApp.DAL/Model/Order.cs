using System;
namespace WoltApp.DAL.Model
{
    public class Order
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public List<Food> Food { get; set; }
        public List<OrderLine> OrderLines { get; set; }

        public Order()
        {
            this.Id = new Random().Next(200, 400);

        }
    }
}

