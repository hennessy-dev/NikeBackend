using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Dominio.Entities;
namespace Persistencia.Data.Configurations;
public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> entity)
    {
        entity.HasKey(e => e.Id).HasName("PRIMARY");

        entity.ToTable("product");

        entity.Property(e => e.Id).HasColumnName("id");
        entity.Property(e => e.Descriptions)
            .HasMaxLength(500)
            .HasColumnName("descriptions");
        entity.Property(e => e.Image)
            .HasMaxLength(200)
            .HasColumnName("image");
        entity.Property(e => e.Price).HasColumnName("price");
        entity.Property(e => e.Stock).HasColumnName("stock");
        entity.Property(e => e.Title)
            .HasMaxLength(60)
            .HasColumnName("title");
    }
}