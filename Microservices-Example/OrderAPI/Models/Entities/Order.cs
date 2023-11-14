using OrderAPI.Models.Entities.Enum;

namespace OrderAPI.Models.Entities
{
    public class Order
    {
        public Guid Id { get; set; }
        public Guid BuyerId { get; set; }
        public Guid OrderId { get; set; }   
        public long TotalPrice { get; set; }
        public ICollection <OrderItem> OrderItems { get; set; }
        public OrderStatus OrderStatu { get; set; }    
        public DateTime CreatedTime { get; set; }   
        public Order Orders { get; set; }    
    }
}
