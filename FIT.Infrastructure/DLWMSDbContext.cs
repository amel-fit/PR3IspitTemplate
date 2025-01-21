using FIT.Data;
using FIT.Data.IB230046;
using Microsoft.EntityFrameworkCore;

using System.Configuration;

namespace FIT.Infrastructure
{
    public class DLWMSDbContext : DbContext
    {
        private readonly string dbPutanja;

        public DLWMSDbContext()
        {
            dbPutanja = ConfigurationManager.
                ConnectionStrings["DLWMSBaza"].ConnectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(dbPutanja);
        }
    
        public DbSet<Student> Studenti { get; set; }
        public DbSet<DrzavaIB230046> Drzave { get; set; }
        public DbSet<GradIB230046> Gradovi { get; set; }
        public DbSet<PolozeniPredmetiIB230046> PolozeniPredmeti { get; set; }

    }
}