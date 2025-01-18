using FIT.Data;
using FIT.Data.IB230046;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }

        public DbSet<Student> Studenti { get; set; }
        public DbSet<SpolIB230046> Spolovi { get; set; }
        public DbSet<SemestarIB230046> Semestri { get; set; }
        public DbSet<UvjerenjeIB230046> StudentiUvjerenja { get; set; }
    }
}