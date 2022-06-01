using FMC.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMC.Repository.Context
{
    public class FmcDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Doktor> Doktors { get; set; }
        public DbSet<Hasta> Hastas { get; set; }
        public DbSet<Hastane> Hastanes{ get; set; }
        public DbSet<Ilac> Ilacs { get; set; }
        public DbSet<Ilce> Ilces { get; set; }
        public DbSet<Randevu> Randevus { get; set; }
        public DbSet<Recete> Recetes { get; set; }
        public DbSet<Sehir> Sehirs { get; set; }

        public FmcDbContext()
        {
            Database.SetInitializer(new VeritabaniOlusturucu());
        }
    }
    public class VeritabaniOlusturucu : CreateDatabaseIfNotExists<FmcDbContext>
    {
        protected override void Seed(FmcDbContext context)
        {

        }
    }
}
