namespace ShiftReportDataBase
{
    using Microsoft.EntityFrameworkCore;
    using ShiftReportDataBase.Models;

    public class ShiftReportDbContext : DbContext
    {
      

        public DbSet<Case> Cases { get; init; }

        public DbSet<Engineer> Engineers { get; init; }

        public DbSet<SparePart> SpareParts { get; init; }

        public DbSet<Status> Statuses { get; init; }

        public DbSet<TestEquipment> TestEquipments { get; init; }

        public DbSet<TestEquipmetType> TestEquipmetTypes { get; init; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Config.ConnectionString);
            }

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TestEquipment>()
                .HasOne(te=>te.Type)
                .WithMany(tt=>tt.TestEquipments)
                .HasForeignKey(te=>te.TestEquipmentTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Case>()
                .HasOne(c => c.Status)
                .WithMany(s => s.Cases)
                .HasForeignKey(c => c.StatusId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Case>()
                .HasMany(c => c.UsedSpareParts)
                .WithOne(sp => sp.Case)
                .HasForeignKey(c => c.CaseId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Engineer>()
                .HasMany(e => e.TakenCases)
                .WithOne(c => c.Engineer)
                .HasForeignKey(c => c.EngineerId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }
    }
}
