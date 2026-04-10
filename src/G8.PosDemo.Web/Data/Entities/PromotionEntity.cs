namespace G8.PosDemo.Web.Data.Entities;

public class PromotionEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string PromotionType { get; set; } = "BuyXGetY";
    public string OrderTypeScope { get; set; } = "Takeout";
    public int BuyQuantity { get; set; } = 5;
    public int FreeQuantity { get; set; } = 1;
    public bool IsEnabled { get; set; } = true;
    public int SortOrder { get; set; }
}
