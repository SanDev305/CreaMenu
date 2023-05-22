using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CreaMenu.Models.DB;

public partial class MiMenuContext : DbContext
{
    public MiMenuContext()
    {
    }

    public MiMenuContext(DbContextOptions<MiMenuContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Carne> Carnes { get; set; }

    public virtual DbSet<Comidum> Comida { get; set; }

    public virtual DbSet<Ensaladum> Ensalada { get; set; }

    public virtual DbSet<Grano> Granos { get; set; }

    public virtual DbSet<Guarnicione> Guarniciones { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=SANTIAGO; Database=MiMenu; Trusted_Connection=True; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Carne>(entity =>
        {
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Comidum>(entity =>
        {
            entity.HasOne(d => d.Carnes).WithMany(p => p.Comida)
                .HasForeignKey(d => d.CarnesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Comida_Carnes");

            entity.HasOne(d => d.Ensaladas).WithMany(p => p.Comida)
                .HasForeignKey(d => d.EnsaladasId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Comida_Ensalada");

            entity.HasOne(d => d.Granos).WithMany(p => p.Comida)
                .HasForeignKey(d => d.GranosId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Comida_Granos");

            entity.HasOne(d => d.Guarniciones).WithMany(p => p.Comida)
                .HasForeignKey(d => d.GuarnicionesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Comida_Guarniciones");
        });

        modelBuilder.Entity<Ensaladum>(entity =>
        {
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Grano>(entity =>
        {
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Guarnicione>(entity =>
        {
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
