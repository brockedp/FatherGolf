using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

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

            modelBuilder.Entity<GolfScoreCard>(entity =>
            {
                entity.ToTable("GolfScoreCard");

                entity.Property(e => e.CourseName).HasMaxLength(100);

                entity.Property(e => e.Date).HasMaxLength(20);

                entity.Property(e => e.PlayerName).HasMaxLength(100);
            });

            modelBuilder.Entity<Golfer>(entity =>
            {
                //entity.HasNoKey();

                entity.ToTable("Golfer");
                entity.Property(e => e.Id).ValueGeneratedNever();


                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("FIRSTNAME");

                entity.Property(e => e.Handicap).HasColumnName("HANDICAP");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

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
    }
}
