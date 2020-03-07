using Microsoft.EntityFrameworkCore;
using LinxApi.Models;

namespace testeef.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            :base(options)
            {    
            }
        public DbSet<ProdutoImportado> Produtos { get; set; }
    }
}