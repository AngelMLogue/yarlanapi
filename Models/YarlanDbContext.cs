using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace YarlanAPI.Models;

public partial class YarlanDbContext : DbContext
{

    public YarlanDbContext(DbContextOptions<YarlanDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Mensaje> Mensajes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Mensaje>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Mensajes__3214EC27A21BE96A");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Alerta).HasColumnName("Mensaje");
            entity.Property(e => e.TipoUsuario).HasColumnName("TipoUsuario");
            entity.Property(e => e.Zona).HasColumnName("Zona");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
