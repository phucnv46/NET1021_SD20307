using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace B4_KetNoiDatabase_EFCore.Models;

public partial class Sd20307Context : DbContext
{
    public Sd20307Context()
    {
    }

    public Sd20307Context(DbContextOptions<Sd20307Context> options)
        : base(options)
    {
    }

    public virtual DbSet<LichHoc> LichHocs { get; set; }

    public virtual DbSet<Mon> Mons { get; set; }

    public virtual DbSet<SinhVien> SinhViens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=ADMIN-PC;Database=SD20307;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<LichHoc>(entity =>
        {
            entity.HasKey(e => new { e.MaSinhVien, e.MaMon }).HasName("PK__LichHoc__003F55EFF5D8F7A6");

            entity.ToTable("LichHoc");

            entity.Property(e => e.MaSinhVien)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.MaMonNavigation).WithMany(p => p.LichHocs)
                .HasForeignKey(d => d.MaMon)
                .HasConstraintName("FK_LichHoc_Mon");

            entity.HasOne(d => d.MaSinhVienNavigation).WithMany(p => p.LichHocs)
                .HasForeignKey(d => d.MaSinhVien)
                .HasConstraintName("FK_LichHoc_SinhVien");
        });

        modelBuilder.Entity<Mon>(entity =>
        {
            entity.ToTable("Mon");

            entity.Property(e => e.TenMon).HasMaxLength(255);
        });

        modelBuilder.Entity<SinhVien>(entity =>
        {
            entity.HasKey(e => e.MaSinhVien).HasName("PK__SinhVien__939AE7751FDE1AA8");

            entity.ToTable("SinhVien");

            entity.Property(e => e.MaSinhVien)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DiaChi).HasMaxLength(500);
            entity.Property(e => e.NgaySinh).HasColumnType("datetime");
            entity.Property(e => e.TenSinhVien).HasMaxLength(255);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
