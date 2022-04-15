using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ConsoleTask1.Models
{
    public partial class dbContext : DbContext
    {
        public dbContext()
        {
        }

        public dbContext(DbContextOptions<dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Productdetail> Productdetails { get; set; } = null!;
        public virtual DbSet<Ram> Rams { get; set; } = null!;
        public virtual DbSet<RegDetail> RegDetails { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=RAM;Initial Catalog=db;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Productdetail>(entity =>
            {
                entity.HasKey(e => e.Pcode)
                    .HasName("PK__productd__293812AA62740314");

                entity.ToTable("productdetails");

                entity.Property(e => e.Pcode)
                    .ValueGeneratedNever()
                    .HasColumnName("pcode");

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("category");

                entity.Property(e => e.Pdesc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pdesc");

                entity.Property(e => e.Pname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pname");

                entity.Property(e => e.Price)
                    .HasColumnType("money")
                    .HasColumnName("price");

                entity.Property(e => e.Stockinhand).HasColumnName("stockinhand");
            });

            modelBuilder.Entity<Ram>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ram");

                entity.Property(e => e.Nameis)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("nameis");
            });

            modelBuilder.Entity<RegDetail>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK__RegDetai__C2B7EDE8A065B750");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("rid");

                entity.Property(e => e.Contactno).HasColumnName("contactno");

                entity.Property(e => e.Experience)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("experience");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("firstname");

                entity.Property(e => e.Mailid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mailid");

                entity.Property(e => e.Skills)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("skills");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("student");

                entity.Property(e => e.Feemoney)
                    .HasColumnType("money")
                    .HasColumnName("feemoney");

                entity.Property(e => e.Stdroll).HasColumnName("stdroll");

                entity.Property(e => e.Stname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("stname");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
