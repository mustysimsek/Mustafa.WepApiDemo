using Microsoft.EntityFrameworkCore;
using Support.Domain.Entities;

namespace Support.Persistence.Context
{
    public class BevBreadDBContext : DbContext
    {
        public BevBreadDBContext(DbContextOptions<BevBreadDBContext> options) : base(options)
        {

        }
        public DbSet<Product> STProduct { get; set; }
        public DbSet<ProductVariant> STProductVariant { get; set; }
        public DbSet<BranchProductRelation> STBranchProductRelation { get; set; }
        public DbSet<Branch> STBranch { get; set; }
        public DbSet<ProductCategory> MTProductCategory { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 
        }
    }
}
