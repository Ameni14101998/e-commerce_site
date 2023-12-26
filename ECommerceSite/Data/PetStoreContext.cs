using Microsoft.EntityFrameworkCore;
namespace ECommerceSite.Data
{
    public class AmeniStoreContext : DbContext
    {
        public AmeniStoreContext(DbContextOptions<AmeniStoreContext> options) : base(options)
        {

        }
        public DbSet<Models.Product> Products { get; set; }
        public DbSet<Models.Member> Members { get; set; }
    }
}
