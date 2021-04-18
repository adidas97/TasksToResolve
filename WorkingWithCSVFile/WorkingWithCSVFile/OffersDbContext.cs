using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace WorkingWithCSVFile
{
    public class OffersDbContext : DbContext
    {
        static readonly string connectionString = ConfigurationManager.AppSettings.Get("ConnectionString");
        public DbSet<Offer> Offers { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // We use the Fluent API to set our colum names in database with exactly the same name as our input is given,
            // using our helper class ProcessInput to get the correct colum name which than we set it using methods of Fluent API

            builder.Entity<Offer>().Property(e => e.OfferId).HasColumnName(ProcessInput.GetOfferId());
            builder.Entity<Offer>().Property(e => e.MonthlyFee).HasColumnName(ProcessInput.GetMonthlyFee());
            builder.Entity<Offer>().Property(e => e.NewContractsForMonth).HasColumnName(ProcessInput.GetNewContractsForMonth());
            builder.Entity<Offer>().Property(e => e.SameContractsForMonth).HasColumnName(ProcessInput.GetSameContractsForMonth());
            builder.Entity<Offer>().Property(e => e.CancelledContractsForMonth).HasColumnName(ProcessInput.GetCancelledContractsForMonth());
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // We get our connection string path. You can change it from App.config file
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}