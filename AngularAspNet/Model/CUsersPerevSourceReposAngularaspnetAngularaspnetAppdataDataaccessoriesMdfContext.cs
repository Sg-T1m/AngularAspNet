using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AngularAspNet.Model;

public partial class CUsersPerevSourceReposAngularaspnetAngularaspnetAppdataDataaccessoriesMdfContext : DbContext
{
    public CUsersPerevSourceReposAngularaspnetAngularaspnetAppdataDataaccessoriesMdfContext()
    {
    }

    public CUsersPerevSourceReposAngularaspnetAngularaspnetAppdataDataaccessoriesMdfContext(DbContextOptions<CUsersPerevSourceReposAngularaspnetAngularaspnetAppdataDataaccessoriesMdfContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Compatibility> Compatibilities { get; set; }

    public virtual DbSet<Component> Components { get; set; }

    public virtual DbSet<ComponentsType> ComponentsTypes { get; set; }

    public virtual DbSet<Manufacturer> Manufacturers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\perev\\source\\repos\\AngularAspNet\\AngularAspNet\\AppData\\DataAccessories.mdf;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Compatibility>(entity =>
        {
            entity.HasKey(e => e.ComponentId1).HasName("PK__compatib__15C0EF1079B194CA");

            entity.ToTable("compatibilities");

            entity.Property(e => e.ComponentId1)
                .ValueGeneratedNever()
                .HasColumnName("component_id_1");
            entity.Property(e => e.ComponentId2).HasColumnName("component_id_2");

            entity.HasOne(d => d.ComponentId2Navigation).WithMany(p => p.Compatibilities)
                .HasForeignKey(d => d.ComponentId2)
                .HasConstraintName("FK_component_id_2");
        });

        modelBuilder.Entity<Component>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__componen__3214EC07E1E2F49F");

            entity.ToTable("components");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.AllMemory).HasColumnName(" AllMemory");
            entity.Property(e => e.Capacity)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.ClockFrequency)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("ClockFrequency ");
            entity.Property(e => e.Collor)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CompatibilitiesId).HasColumnName("compatibilities_id");
            entity.Property(e => e.ComponentsTypeId).HasColumnName("components_type_id");
            entity.Property(e => e.CpubaseFrequency)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("CPUBaseFrequency");
            entity.Property(e => e.Img)
                .HasMaxLength(200)
                .IsFixedLength();
            entity.Property(e => e.ManufacturersId).HasColumnName("manufacturers_id");
            entity.Property(e => e.MemoryType)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("name");
            entity.Property(e => e.PowerMominal).HasColumnName("PowerMominal ");
            entity.Property(e => e.Price)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("price");
            entity.Property(e => e.Socket)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("socket");
            entity.Property(e => e.Type)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.VolumeOfOneMemoryModule).HasColumnName("Volume of one memory module");
            entity.Property(e => e.Weight)
                .HasMaxLength(10)
                .IsFixedLength();

            entity.HasOne(d => d.ComponentsType).WithMany(p => p.Components)
                .HasForeignKey(d => d.ComponentsTypeId)
                .HasConstraintName("FK_manufacturers_type_id");

            entity.HasOne(d => d.Manufacturers).WithMany(p => p.Components)
                .HasForeignKey(d => d.ManufacturersId)
                .HasConstraintName("FK_manufacturers_id");
        });

        modelBuilder.Entity<ComponentsType>(entity =>
        {
            entity.ToTable("components_type");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsFixedLength();
        });

        modelBuilder.Entity<Manufacturer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__manufact__3214EC07D68235C5");

            entity.ToTable("manufacturers");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name)
                .HasMaxLength(40)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
