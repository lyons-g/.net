using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Assignment6
{
    public partial class Assignment6Context : DbContext
    {
        public Assignment6Context()
        {
        }

        public Assignment6Context(DbContextOptions<Assignment6Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Vehicle> Vehicle { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Assignment6;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehicle>(entity =>
            {
               // entity.HasNoKey();
                entity.HasKey(e => e.StudentId);

                entity.Property(e => e.Owner).IsUnicode(false);

                entity.Property(e => e.Registration).IsUnicode(false);

                entity.Property(e => e.StudentId).HasColumnName("Student_Id");

                entity.Property(e => e.VehicleModel)
                    .HasColumnName("Vehicle_Model")
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
