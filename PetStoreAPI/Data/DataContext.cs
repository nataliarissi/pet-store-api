using Microsoft.EntityFrameworkCore;
using PetStoreAPI.Models;

namespace PetStoreAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.;Database=petstoredb;User Id=sa;Password=Natalia@123;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>().HasKey(a => a.Id);
        }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
