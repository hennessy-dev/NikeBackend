using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Dominio.Entities;
namespace Persistencia.Data.Configurations;
public class OptionConfiguration : IEntityTypeConfiguration<Option>
{
    public void Configure(EntityTypeBuilder<Option> entity)
    {
        entity.HasKey(e => e.Id).HasName("PRIMARY");

        entity.ToTable("option");

        entity.Property(e => e.Id).HasColumnName("id");
        entity.Property(e => e.OptionName)
            .HasMaxLength(70)
            .HasColumnName("option_name");
        entity.Property(e => e.OptionType)
            .HasMaxLength(70)
            .HasColumnName("option_type");
    }
}