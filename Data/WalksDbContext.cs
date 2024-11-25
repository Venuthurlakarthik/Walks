using Microsoft.EntityFrameworkCore;
using Walks.Controllers.DomainModels;

namespace WalksDbContext.Data
{
    
        public class WalksDbContext : DbContext
        {
            public WalksDbContext(DbContextOptions options) : base(options) { }
          

            
        public DbSet<students> students { get; set; }
        public DbSet<teachers> teachers { get; set; }
        public DbSet<Department> departments { get; set; }
        }
    }

