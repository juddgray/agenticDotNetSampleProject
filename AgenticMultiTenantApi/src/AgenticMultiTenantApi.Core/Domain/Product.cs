namespace AgenticMultiTenantApi.Core.Domain;

public sealed class Product
{
    public Guid Id { get; set; }

    public string TenantId { get; set; } = string.Empty;

    public Tenant? Tenant { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Sku { get; set; } = string.Empty;

    public string? Description { get; set; }

    public decimal Price { get; set; }

    public bool IsActive { get; set; } = true;

    public DateTime CreatedUtc { get; set; }

    public DateTime? UpdatedUtc { get; set; }
}
