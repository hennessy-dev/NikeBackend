using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Dominio.Entities;
namespace Persistencia.Data.Configurations;
public class ProductOptionConfiguration : IEntityTypeConfiguration<ProductOption>
{
    public void Configure(EntityTypeBuilder<ProductOption> entity)
    {
        entity.HasKey(e => e.Id).HasName("PRIMARY");

        entity.ToTable("product_option");

        entity.HasIndex(e => e.OptionsId, "option_fk_idx");

        entity.HasIndex(e => e.ProductId, "product_fk_idx");

        entity.Property(e => e.Id)
            .ValueGeneratedNever()
            .HasColumnName("id");
        entity.Property(e => e.OptionsId).HasColumnName("options_id");
        entity.Property(e => e.ProductId).HasColumnName("product_id");

        entity.HasOne(d => d.Options).WithMany(p => p.ProductOptions)
            .HasForeignKey(d => d.OptionsId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_option_product");

        entity.HasOne(d => d.Product).WithMany(p => p.ProductOptions)
            .HasForeignKey(d => d.ProductId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_product_option");
    }
}