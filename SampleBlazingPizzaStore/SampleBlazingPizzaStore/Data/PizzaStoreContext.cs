using Microsoft.EntityFrameworkCore;
using SampleBlazingPizzaStore.Models;

namespace SampleBlazingPizzaStore.Data
{
    public class PizzaStoreContext : DbContext
    {
        public PizzaStoreContext(DbContextOptions<PizzaStoreContext> options)
            : base(options)
        {
        }

        public DbSet<PizzaSpecial> Specials { get; set; }
     
    }
}
