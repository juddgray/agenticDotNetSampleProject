namespace AgenticMultiTenantApi.Core.Abstractions;

public interface ITenantService
{
    string? CurrentTenantId { get; set; }

    Task<string?> GetCurrentTenantIdAsync(CancellationToken cancellationToken = default);

    Task SetCurrentTenantIdAsync(string tenantId, CancellationToken cancellationToken = default);

    Task ClearCurrentTenantIdAsync(CancellationToken cancellationToken = default);
}
