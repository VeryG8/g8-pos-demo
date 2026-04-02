namespace G8.PosDemo.Web.Data.Entities;

public class ProductEntity
{
    public int Id { get; set; }
    public int CategoryId { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal BasePrice { get; set; }
    public string SizeOptions { get; set; } = "M";
    public bool IsTea { get; set; }
    public bool IsEnabled { get; set; }

    public ProductCategoryEntity? Category { get; set; }
}
