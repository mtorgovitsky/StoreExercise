using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreExercise.Models
{
    public class CarsContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=customers.db");
            //optionsBuilder.UseSqlite("Data Source=cars.sql3");

            //base.OnConfiguring(optionsBuilder);
        }
    }
}
