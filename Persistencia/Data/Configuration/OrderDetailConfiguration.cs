using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Dominio.Entities;
namespace Persistencia.Data.Configurations;
public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
{
    public void Configure(EntityTypeBuilder<OrderDetail> entity)
    {
        entity.HasKey(e => e.Id).HasName("PRIMARY");

        entity.ToTable("order_details");

        entity.HasIndex(e => e.OrderId, "order_fk_idx");

        entity.HasIndex(e => e.ProductId, "product_fk_idx");

        entity.Property(e => e.Id).HasColumnName("id");
        entity.Property(e => e.OrderId).HasColumnName("order_id");
        entity.Property(e => e.Price).HasColumnName("price");
        entity.Property(e => e.ProductId).HasColumnName("product_id");
        entity.Property(e => e.Quantity).HasColumnName("quantity");

        entity.HasOne(d => d.Order).WithMany(p => p.OrderDetails)
            .HasForeignKey(d => d.OrderId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("order_fk");

        entity.HasOne(d => d.Product).WithMany(p => p.OrderDetails)
            .HasForeignKey(d => d.ProductId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("product_fk");
    }
}