using AgenticMultiTenantApi.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace AgenticMultiTenantApi.Infrastructure.Persistence;

public sealed class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Tenant> Tenants => Set<Tenant>();

    public DbSet<Product> Products => Set<Product>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Tenant>(entity =>
        {
            entity.HasKey(tenant => tenant.Id);
            entity.Property(tenant => tenant.Id).IsRequired();
            entity.Property(tenant => tenant.Name).HasMaxLength(200).IsRequired();
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(product => product.Id);
            entity.Property(product => product.TenantId).HasMaxLength(100).IsRequired();
            entity.Property(product => product.Name).HasMaxLength(200).IsRequired();
            entity.Property(product => product.Sku).HasMaxLength(100).IsRequired();

            entity.HasOne(product => product.Tenant)
                .WithMany(tenant => tenant.Products)
                .HasForeignKey(product => product.TenantId)
                .OnDelete(DeleteBehavior.Cascade);
        });
    }
}
