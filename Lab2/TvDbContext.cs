using System.Data.Entity;

namespace Lab2 {
    public class TvDbContext : DbContext {
        public TvDbContext(string nameOrConnectionString) : base(nameOrConnectionString) { }

        public DbSet<TV> TVs { get; set; }
    }
}
