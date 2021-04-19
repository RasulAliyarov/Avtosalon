using Avtosolon.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avtosolon.Data
{
    public class DBContent : DbContext
    {
        public DBContent(DbContextOptions<DBContent> option) : base(option) { }

        public DbSet<InfoCar> dbInfoCar { get; set; }
        public DbSet<Categories> dbCategories { get; set; }

        public DbSet<DanniyeKorzini> danniyeKorzini { get; set; }

        public DbSet<Zakaz> dbZakaza { get; set; }
        public DbSet<ElementiZakaza> dbElementiZakaza { get; set; }
    }
}
