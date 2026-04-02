namespace G8.PosDemo.Web.Data.Entities;

public class OrderItemEntity
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public string ProductName { get; set; } = string.Empty;
    public string Size { get; set; } = "M";
    public string Sugar { get; set; } = string.Empty;
    public string Ice { get; set; } = string.Empty;
    public string? Toppings { get; set; }
    public string? Note { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }

    public OrderEntity? Order { get; set; }
}
