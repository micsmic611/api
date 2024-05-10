using Microsoft.EntityFrameworkCore;
using WMSLite.Core.Api.src.Entities;

namespace WMSLite.Core.Api
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        
        public DbSet<ItemLocationAssignmentDbo> ItemLocationAssignment { get; set; }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Add configuration for other entities here
        }
    }
}
