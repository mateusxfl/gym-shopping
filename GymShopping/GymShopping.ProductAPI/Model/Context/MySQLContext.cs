using Microsoft.EntityFrameworkCore;

namespace GymShopping.ProductAPI.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() { }
        
        public MySQLContext(DbContextOptions<MySQLContext> options) : base (options) { }
    }
}
