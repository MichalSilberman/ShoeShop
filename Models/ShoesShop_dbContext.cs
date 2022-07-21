using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DAL.Models
{
    public partial class ShoesShop_dbContext : DbContext
    {
        public ShoesShop_dbContext()
        {
        }

        public ShoesShop_dbContext(DbContextOptions<ShoesShop_dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CategoryTbl> CategoryTbl { get; set; }
        public virtual DbSet<CustomersTbl> CustomersTbl { get; set; }
        public virtual DbSet<ShoesTbl> ShoesTbl { get; set; }
        public virtual DbSet<ShopDetailsTbl> ShopDetailsTbl { get; set; }
        public virtual DbSet<ShopsTbl> ShopsTbl { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=WINDOWS-O5FQOUT;Database=ShoesShop_db;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<CategoryTbl>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK__Category__23CAF1D86C015681");

                entity.ToTable("Category_tbl");

                entity.Property(e => e.CategoryId).HasColumnName("categoryId");

                entity.Property(e => e.CategoreyName)
                    .HasColumnName("categoreyName")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomersTbl>(entity =>
            {
                entity.HasKey(e => e.CustId)
                    .HasName("PK__Customer__9725F2C68ECD8C44");

                entity.ToTable("Customers_tbl");

                entity.Property(e => e.CustId).HasColumnName("custId");

                entity.Property(e => e.CreditCardNumber)
                    .HasColumnName("creditCardNumber")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CustName)
                    .HasColumnName("custName")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustPassword)
                    .HasColumnName("custPassword")
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ShoesTbl>(entity =>
            {
                entity.HasKey(e => e.ShoeId)
                    .HasName("PK__Shoes_tb__E407F887535EA9E0");

                entity.ToTable("Shoes_tbl");

                entity.Property(e => e.ShoeId).HasColumnName("shoeId");

                entity.Property(e => e.AmountOnStock).HasColumnName("amountOnStock");

                entity.Property(e => e.CategoryId).HasColumnName("categoryId");

                entity.Property(e => e.Color)
                    .HasColumnName("color")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("money");

                entity.Property(e => e.ShoeImage)
                    .HasColumnName("shoeImage")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShoeName)
                    .HasColumnName("shoeName")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Size)
                    .HasColumnName("size")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.ShoesTbl)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__Shoes_tbl__categ__619B8048");
            });

            modelBuilder.Entity<ShopDetailsTbl>(entity =>
            {
                entity.HasKey(e => e.ShopDetailId)
                    .HasName("PK__ShopDeta__EE35863434FC8699");

                entity.ToTable("ShopDetails_tbl");

                entity.Property(e => e.ShopDetailId).HasColumnName("shopDetailId");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.ShoeCode).HasColumnName("shoeCode");

                entity.Property(e => e.ShopNum).HasColumnName("shopNum");

                entity.HasOne(d => d.ShoeCodeNavigation)
                    .WithMany(p => p.ShopDetailsTbl)
                    .HasForeignKey(d => d.ShoeCode)
                    .HasConstraintName("FK__ShopDetai__shoeC__656C112C");

                entity.HasOne(d => d.ShopNumNavigation)
                    .WithMany(p => p.ShopDetailsTbl)
                    .HasForeignKey(d => d.ShopNum)
                    .HasConstraintName("FK__ShopDetai__shopN__6477ECF3");
            });

            modelBuilder.Entity<ShopsTbl>(entity =>
            {
                entity.HasKey(e => e.ShopNum)
                    .HasName("PK__Shops_tb__C4C2FB76E9905DEF");

                entity.ToTable("Shops_tbl");

                entity.Property(e => e.ShopNum).HasColumnName("shopNum");

                entity.Property(e => e.CustId).HasColumnName("custId");

                entity.Property(e => e.ShopDate)
                    .HasColumnName("shopDate")
                    .HasColumnType("date");

                entity.Property(e => e.Summary)
                    .HasColumnName("summary")
                    .HasColumnType("money");

                entity.HasOne(d => d.Cust)
                    .WithMany(p => p.ShopsTbl)
                    .HasForeignKey(d => d.CustId)
                    .HasConstraintName("FK__Shops_tbl__custI__5CD6CB2B");
            });
        }
    }
}
