using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Dominio.Entities;
namespace Persistencia.Data.Configurations;
public class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
{
    public void Configure(EntityTypeBuilder<ProductCategory> entity)
    {
        entity.HasKey(e => e.Id).HasName("PRIMARY");

        entity.ToTable("product_categories");

        entity.HasIndex(e => e.CategoryId, "category_fk_idx");

        entity.HasIndex(e => e.ProductId, "product_fk_idx");

        entity.Property(e => e.Id)
            .ValueGeneratedNever()
            .HasColumnName("id");
        entity.Property(e => e.CategoryId).HasColumnName("category_id");
        entity.Property(e => e.ProductId).HasColumnName("product_id");

        entity.HasOne(d => d.Category).WithMany(p => p.ProductCategories)
            .HasForeignKey(d => d.CategoryId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_category");

        entity.HasOne(d => d.Product).WithMany(p => p.ProductCategories)
            .HasForeignKey(d => d.ProductId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_product");
    }
}