using Business.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Maps;


namespace Persistence
{
    public class PrincipalContext : DbContext
    {
        public DbSet<Data> Data { get; set; }

        public PrincipalContext(DbContextOptions<PrincipalContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DataMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}