using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CustomerCareWebApp.DAl;

public partial class CustomercareDbContext : DbContext
{
    public CustomercareDbContext()
    {
    }

    public CustomercareDbContext(DbContextOptions<CustomercareDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Complaint> Complaints { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<StatusMaster> StatusMasters { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ccdb1");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Complaint>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Complain__3214EC27E4262F61");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ActionDate).HasColumnType("datetime");
            entity.Property(e => e.DateOfRegistration).HasColumnType("datetime");
            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MobileNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Status).WithMany(p => p.Complaints)
                .HasForeignKey(d => d.StatusId)
                .HasConstraintName("FK__Complaint__Statu__3E52440B");

            entity.HasOne(d => d.User).WithMany(p => p.Complaints)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Complaint__UserI__3F466844");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Roles__3214EC075E6D6835");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<StatusMaster>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__StatusMa__3214EC07ADE0E211");

            entity.ToTable("StatusMaster");

            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Users__3214EC27A2BBC7DE");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK__Users__RoleId__38996AB5");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
