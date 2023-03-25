using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models;

public partial class InventoryContext : DbContext
{
    public InventoryContext()
    {
    }

    public InventoryContext(DbContextOptions<InventoryContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BrandTable> BrandTables { get; set; }

    public virtual DbSet<KindTable> KindTables { get; set; }

    public virtual DbSet<ProductTable> ProductTables { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BrandTable>(entity =>
        {
            entity.HasKey(e => e.IdBrand);

            entity.ToTable("BrandTable");

            entity.Property(e => e.Brand)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<KindTable>(entity =>
        {
            entity.HasKey(e => e.Idkind);

            entity.ToTable("kindTable");

            entity.Property(e => e.Kind)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ProductTable>(entity =>
        {
            entity.HasKey(e => e.IdProduct);

            entity.ToTable("ProductTable");

            entity.Property(e => e.Fkbrand).HasColumnName("FKBrand");
            entity.Property(e => e.Kfkind).HasColumnName("KFKind");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.FkbrandNavigation).WithMany(p => p.ProductTables)
                .HasForeignKey(d => d.Fkbrand)
                .HasConstraintName("FK_ProductTable_BrandTable");

            entity.HasOne(d => d.KfkindNavigation).WithMany(p => p.ProductTables)
                .HasForeignKey(d => d.Kfkind)
                .HasConstraintName("FK_ProductTable_kindTable");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
