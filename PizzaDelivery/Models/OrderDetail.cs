namespace PizzaDelivery.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        //Foreign Key - uses this to link OrderDetail → Order
        public int OrderId { get; set; }

        //Foreign Key - uses this to link OrderDetail → Product
        public int ProductId { get; set; }



        //navigation property - gives you the full Order object related to the order detail.
        public Order Order { get; set; } = null!;
        
        //navigation property - gives you the full Product object related to the order detail.
        public Product Product { get; set; } = null!;
        
    }
}