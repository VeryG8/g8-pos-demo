namespace G8.PosDemo.Web.Data.Entities;

public class CustomerEntity
{
    public int Id { get; set; }
    public string Phone { get; set; } = string.Empty;
    public string? DisplayName { get; set; }
    public int LoyaltyPoints { get; set; }
}
