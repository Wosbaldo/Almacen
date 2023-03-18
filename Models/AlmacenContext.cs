﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Almacen.Models;

public partial class AlmacenContext : DbContext
{
    public AlmacenContext()
    {
       // Producto producto = new Producto();
       // producto.Id = 01;
       // producto.Nombre = "Manzana";
       // producto.Descripción = "Frutas frescas";
       //producto.Stokck = 50;

        //db.Productos.Add(producto);
        //db.SaveChanges();
    }

    public AlmacenContext(DbContextOptions<AlmacenContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Producto> Productos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOP-I0DMFLAE\\SQLEXPRESS;Database=Almacen;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.Precio);

            entity.ToTable("Producto");

            entity.Property(e => e.Precio).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Descripción)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
