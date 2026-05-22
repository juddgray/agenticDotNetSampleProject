namespace AgenticMultiTenantApi.Core.Domain;

public sealed class Tenant
{
    public string Id { get; set; } = string.Empty;

    public string Name { get; set; } = string.Empty;

    public bool IsActive { get; set; } = true;

    public DateTime CreatedUtc { get; set; }

    public DateTime? UpdatedUtc { get; set; }

    public ICollection<Product> Products { get; set; } = new List<Product>();
}
