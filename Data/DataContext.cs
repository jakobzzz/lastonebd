using Microsoft.EntityFrameworkCore;
using lastonebd.Data;

namespace lastonebd.Data
{
    internal class DataContext : DbContext
    {

        public DbSet<IWorkers> IWorkersTab { get; set; }
        public DbSet<ISection> ISections { get; set; }
        public DbSet<Offers> OffersTab { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=iFactory;Trusted_Connection=True");

        }
    }
}
