using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Dominio.Entities;
namespace Persistencia.Data.Configurations;
public class RefreshTokenConfiguration : IEntityTypeConfiguration<RefreshToken>
{
    public void Configure(EntityTypeBuilder<RefreshToken> entity)
    {
        entity.HasKey(e => e.Id).HasName("PRIMARY");

        entity.ToTable("refresh_token");

        entity.HasIndex(e => e.UserId, "userFk_idx");

        entity.Property(e => e.Id).HasColumnName("id");
        entity.Property(e => e.Created)
            .HasColumnType("timestamp")
            .HasColumnName("created");
        entity.Property(e => e.Expires)
            .HasColumnType("datetime")
            .HasColumnName("expires");
        entity.Property(e => e.IsActive).HasColumnName("isActive");
        entity.Property(e => e.Revoked)
            .HasMaxLength(45)
            .HasColumnName("revoked");
        entity.Property(e => e.Token)
            .HasMaxLength(500)
            .HasColumnName("token");
        entity.Property(e => e.UserId).HasColumnName("user_id");

        entity.HasOne(d => d.User).WithMany(p => p.RefreshTokens)
            .HasForeignKey(d => d.UserId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("user_fk");
    }
}