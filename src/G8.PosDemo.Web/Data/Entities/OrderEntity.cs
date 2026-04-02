namespace G8.PosDemo.Web.Data.Entities;

public class OrderEntity
{
    public int Id { get; set; }
    public string OrderCode { get; set; } = string.Empty;
    public string PaymentMethod { get; set; } = string.Empty;
    public string? CustomerPhone { get; set; }
    public decimal TotalAmount { get; set; }
    public string? OrderSummary { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public ICollection<OrderItemEntity> Items { get; set; } = new List<OrderItemEntity>();
}
