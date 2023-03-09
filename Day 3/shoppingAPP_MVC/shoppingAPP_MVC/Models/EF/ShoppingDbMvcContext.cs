using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace shoppingAPP_MVC.Models.EF;

public partial class ShoppingDbMvcContext : DbContext
{
    public ShoppingDbMvcContext()
    {
    }

    public ShoppingDbMvcContext(DbContextOptions<ShoppingDbMvcContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=shoppingDB_MVC;integrated security=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CId).HasName("PK__customer__D830D4772358802D");

            entity.ToTable("customers");

            entity.Property(e => e.CId)
                .ValueGeneratedNever()
                .HasColumnName("cId");
            entity.Property(e => e.CAddress)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cAddress");
            entity.Property(e => e.CIsActive).HasColumnName("cIsActive");
            entity.Property(e => e.CName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cName");
            entity.Property(e => e.CWalletBalance).HasColumnName("cWalletBalance");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Pid).HasName("PK__Products__DD37D91AB209622E");

            entity.Property(e => e.Pid)
                .ValueGeneratedNever()
                .HasColumnName("pid");
            entity.Property(e => e.PCategory)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("pCategory");
            entity.Property(e => e.PIsInStock).HasColumnName("pIsInStock");
            entity.Property(e => e.PName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("pName");
            entity.Property(e => e.PPrice).HasColumnName("pPrice");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
