
using GeekShopping.CartAPI.Model.Base;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.CartAPI.Model.Context
{
    public class MySQLContext: DbContext
    {

        public MySQLContext(DbContextOptions<MySQLContext> options ) : base (options)
        {

        }

        public DbSet<Product> Products { get; set; }// = null!;
        public DbSet<CartDetail> CartDetails { get; set; }
        public DbSet<CartHeader> CartHeaders { get; set; }

        
    }
}
