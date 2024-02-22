using FIT.Data;
using FIT.Data.IB220235;
using Microsoft.EntityFrameworkCore;

using System.Configuration;
using System.Drawing.Drawing2D;

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

        public DbSet<DrzavaIB220235> DrzaveIB220235 { get; set; }

        public DbSet<GradIB220235> GradoviIB220235 { get; set; }

        public DbSet<PolozeniPredmetiIB220235> PolozeniPredmeti {  get; set; }

        public DbSet<PredmetIB220235> Predmeti { get; set; }

        public DbSet<SemestarIB220235?> Semestri { get; set; }

    }
}