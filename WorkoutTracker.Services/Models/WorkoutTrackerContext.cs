using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WorkoutTracker.Core.Models
{
    public partial class WorkoutTrackerContext : DbContext
    {
        public WorkoutTrackerContext()
        {
        }

        public WorkoutTrackerContext(DbContextOptions<WorkoutTrackerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Exercises> Exercises { get; set; }
        public virtual DbSet<WorkoutItems> WorkoutItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=WorkoutTracker;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Exercises>(entity =>
            {
                entity.HasKey(e => e.ExerciseId);

                entity.Property(e => e.AddDate).HasColumnType("date");

                entity.Property(e => e.AddName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ExerciseDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ExerciseName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WorkoutItems>(entity =>
            {
                entity.HasKey(e => e.WorkoutItemId);

                entity.Property(e => e.AddDate).HasColumnType("date");

                entity.Property(e => e.AddName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Exercise)
                    .WithMany(p => p.WorkoutItems)
                    .HasForeignKey(d => d.ExerciseId)
                    .HasConstraintName("FK__WorkoutIt__Exerc__25869641");
            });
        }
    }
}
