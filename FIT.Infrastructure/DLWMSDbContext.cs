using FIT.Data;
using FIT.Data.IspitIB230046;
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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Student> Studenti { get; set; }
        public DbSet<PredmetIB230046> Predmeti { get; set; }
        public DbSet<PolozeniPredmetIB230046> PolozeniPredmeti { get; set; }
        public DbSet<UlogaIB230046> Uloge { get; set; }
        public DbSet<StudentUlogaIB230046> StudentiUloge { get; set; }
        public DbSet<SemestarIB230046> Semestri { get; set; }
        public DbSet<StudentPorukaIB230046> StudentiPoruke { get; set; }

    }
}