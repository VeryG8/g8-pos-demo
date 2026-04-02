namespace G8.PosDemo.Web.Data.Entities;

public class ProductCategoryEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int SortOrder { get; set; }

    public ICollection<ProductEntity> Products { get; set; } = new List<ProductEntity>();
}
