using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzarendeles.Data
{
    public class PizzarendelesekContext : DbContext
    {
        public DbSet<Models.Ugyfel> Ugyfelek { get; set; }
        public DbSet<Models.Pizza> Pizzak { get; set; }
        public DbSet<Models.Rendeles> Rendelesek { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=PizzarendelesDb;Trusted_Connection=True;");
        }

        //Na ezt az AI súgta meg,mert noha megvan a pizzadatában a lista, de nem jelent meg a comboboxban, mert nem volt a contextben a pizzákra vonatkozó adatfeltöltés. 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Models.Pizza>().HasData(Pizzadata.OsszesPizza);
        }

    }
}
