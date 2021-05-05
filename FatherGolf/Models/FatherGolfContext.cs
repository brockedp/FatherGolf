using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using FatherGolf.Models;

#nullable disable

namespace FatherGolf.Models
{
    public partial class FatherGolfContext : DbContext
    {
        public FatherGolfContext()
        {
        }

        public FatherGolfContext(DbContextOptions<FatherGolfContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<GolfScoreCard> GolfScoreCards { get; set; }
        public virtual DbSet<Golfer> Golfers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\sqlexpress;Database=FatherGolf;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Course>(entity =>
            {
                entity.Property(e => e.Address).HasMaxLength(300);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.PhoneNumber).HasMaxLength(30);
            });

            modelBuilder.Entity<GolfScoreCard>(entity =>
            {
                entity.ToTable("GolfScoreCard");

                entity.Property(e => e.Date).HasMaxLength(20);

                entity.Property(e => e.Deleted).HasColumnName("DELETED");
            });

            modelBuilder.Entity<Golfer>(entity =>
            {
                entity.ToTable("Golfer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Deleted).HasColumnName("DELETED");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("FIRSTNAME");

                entity.Property(e => e.Handicap).HasColumnName("HANDICAP");

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("LASTNAME");

                entity.Property(e => e.Totalrounds)
                    .HasMaxLength(100)
                    .HasColumnName("TOTALROUNDS");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public DbSet<FatherGolf.Models.GolfRounds> GolfRounds { get; set; }
    }
}
