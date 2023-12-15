using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class RolConfiguration : IEntityTypeConfiguration<Rol>
{
    public void Configure(EntityTypeBuilder<Rol> entity)
    {

        entity.HasKey(e => e.Id).HasName("PRIMARY");

        entity.ToTable("rol");

        entity.Property(e => e.Id).HasColumnName("id");
        entity.Property(e => e.Name)
            .HasMaxLength(45)
            .HasColumnName("name");

        // entity.HasMany(d => d.Users).WithMany(p => p.Rols)
        //     .UsingEntity<Dictionary<string, object>>(
        //         "UserRol",
        //         r => r.HasOne<User>().WithMany()
        //             .HasForeignKey("UserId")
        //             .OnDelete(DeleteBehavior.ClientSetNull)
        //             .HasConstraintName("userFk"),
        //         l => l.HasOne<Rol>().WithMany()
        //             .HasForeignKey("RolId")
        //             .OnDelete(DeleteBehavior.ClientSetNull)
        //             .HasConstraintName("rolFk"),
        //         j =>
        //         {
        //             j.HasKey("RolId", "UserId")
        //                 .HasName("PRIMARY")
        //                 .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
        //             j.ToTable("user_rol");
        //             j.HasIndex(new[] { "UserId" }, "userFk_idx");
        //             j.IndexerProperty<int>("RolId").HasColumnName("rol_id");
        //             j.IndexerProperty<int>("UserId").HasColumnName("user_id");
        //         });

        
    }
}

