using Microsoft.EntityFrameworkCore;
using testeff.Models;

namespace testeff.Data
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options)
        : base(options)
        {

        }

        public DbSet<Product> Products {get; set;}

        public DbSet<Category> Categorias {get; set;}
  }
}