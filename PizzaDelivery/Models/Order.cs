namespace PizzaDelivery.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderPlaced { get; set; }
        public DateTime? OrderFulfilled { get; set; }

        //Foreign Key - uses this to link Order → Customer
        public int CustomerId { get; set; }


        //navigation property - gives you the full Customer object related to the order.
        public Customer Customer { get; set; } = null!;
        public ICollection<OrderDetail> OrderDetails { get; set; } = null!;
    }
}