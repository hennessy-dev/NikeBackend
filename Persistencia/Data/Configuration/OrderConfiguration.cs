using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Dominio.Entities;
namespace Persistencia.Data.Configurations;
public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> entity)
    {
        entity.HasKey(e => e.Id).HasName("PRIMARY");

        entity.ToTable("order");

        entity.HasIndex(e => e.CustomerId, "customer_fk_idx");

        entity.Property(e => e.Id).HasColumnName("id");
        entity.Property(e => e.Ammount).HasColumnName("ammount");
        entity.Property(e => e.Comments)
            .HasMaxLength(45)
            .HasColumnName("comments");
        entity.Property(e => e.CustomerId).HasColumnName("customer_id");
        entity.Property(e => e.OrderDate)
            .HasColumnType("datetime")
            .HasColumnName("order_date");
        entity.Property(e => e.OrderStatus)
            .HasMaxLength(45)
            .HasColumnName("order_status");
        entity.Property(e => e.ShippingAddress)
            .HasMaxLength(200)
            .HasColumnName("shipping_address");

        entity.HasOne(d => d.Customer).WithMany(p => p.Orders)
            .HasForeignKey(d => d.CustomerId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("customer_fk");
    }
}