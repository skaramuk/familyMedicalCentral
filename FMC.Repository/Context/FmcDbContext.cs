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
    }
}
