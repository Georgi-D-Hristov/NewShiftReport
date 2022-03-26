namespace ShiftReportDataBase
{
    using Microsoft.EntityFrameworkCore;
    using ShiftReportDataBase.Models;

    public class ShiftReportDbContext : DbContext
    {
        public ShiftReportDbContext(DbContextOptions options) : base(options)
        {
        }

        public ShiftReportDbContext()
        {
        }

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
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
