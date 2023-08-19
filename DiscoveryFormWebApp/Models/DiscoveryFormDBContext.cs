using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DiscoveryFormWebApp.Models
{
    public partial class DiscoveryFormDBContext : DbContext
    {
        public DiscoveryFormDBContext()
        {
        }

        public DiscoveryFormDBContext(DbContextOptions<DiscoveryFormDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DiscoveryForm> DiscoveryForms { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=ServerName;Database=DiscoveryFormDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DiscoveryForm>(entity =>
            {
                entity.HasKey(e => e.UniqueDiscoveryFormId);

                entity.Property(e => e.ApprovalStatus).HasMaxLength(100);

                entity.Property(e => e.Category).HasMaxLength(150);

                entity.Property(e => e.CurrentFlag).HasMaxLength(1);

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.InsertedDate).HasColumnType("datetime");

                entity.Property(e => e.Notes).HasMaxLength(4000);

                entity.Property(e => e.Title).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.VisibilityStatus).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
