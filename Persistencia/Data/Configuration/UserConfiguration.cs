using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Dominio.Entities;
namespace Persistencia.Data.Configurations;
public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> entity)
    {
        entity.HasKey(e => e.Id).HasName("PRIMARY");

        entity.ToTable("user");

        entity.Property(e => e.Id).HasColumnName("id");
        entity.Property(e => e.Email)
            .HasMaxLength(60)
            .HasColumnName("email");
        entity.Property(e => e.Password)
            .HasMaxLength(500)
            .HasColumnName("password");
        entity.Property(e => e.Name)
            .HasMaxLength(60)
            .HasColumnName("user");
    }
}