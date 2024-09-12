using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DAL.Models;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL
{
    public class DBContext : DbContext
    {
        //string connectionString = "Server=SantinoLaptop\\SQLEXPRESS;Database=Practico1Seguir;Integrated Security=True;TrustServerCertificate=True";
        string connectionString = "Server=sqlserver;Database=Practico1Seguir;User id=sa; Password=Abc*123!;TrustServerCertificate=True";

        public DBContext() { }

        public DBContext(DbContextOptions<DBContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        { 
            base.OnModelCreating(modelBuilder); 
        }

        public DbSet<Personas> Personas { get; set; }
        public DbSet<Vehiculos> Vehiculos { get; set; }

        public static void UpdateDatabase()
        {
            using (var context = new DBContext())
            {
                context.Database.Migrate();
            }
        }
    }
}
