using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using VehicleDefinition;


/// <summary>
/// this was generated with the following command using "Package Manager Console"
/// Scaffold-DbContext "Server=ALEXV\TESTINSTANCE;Database=shop;User ID=vinteralex;Password=blestem24;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
/// </summary>


namespace CarManagement.Models
{
    public partial class shopContext : DbContext
    {

        Vehicle vehicle_details = new Vehicle();
        public shopContext()
        {
        }

        public shopContext(DbContextOptions<shopContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ClientOrders> ClientOrders { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Persons> Persons { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=ALEXV\\TESTINSTANCE;Database=shop;User ID=vinteralex;Password=blestem24;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClientOrders>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserId)
                    .HasColumnName("ModifyUserID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OrderName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.ClientOrders)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK__ClientOrd__Perso__5CD6CB2B");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Iso2)
                    .HasColumnName("ISO2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Persons>(entity =>
            {
                entity.HasKey(e => e.PersonId);

                entity.HasIndex(e => new { e.PersonId, e.Email })
                    .HasName("Person_Product");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.City)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Persons)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Persons__Country__4BAC3F29");
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ProductDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProductQuantity)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });



            //Vehicle class defined in "VehicleDefinition" namespace
            //========================================================
            modelBuilder.Entity<Vehicle>(entity =>
            {
                entity.HasKey(e => e.VehicleID);

                entity.HasIndex(e => new { e.VehicleID, e.Make, e.Model })
                    .HasName("VehicleId_Make_Model");

                entity.Property(e => e.VehicleID).HasColumnName("VehicleID");

                entity.Property(e => e.DriveType).HasMaxLength(50);

                entity.Property(e => e.EngineDescription).HasMaxLength(50);

                entity.Property(e => e.Make).HasMaxLength(50);

                entity.Property(e => e.Model).HasMaxLength(50);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            });
        }
    }
}
