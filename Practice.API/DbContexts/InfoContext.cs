using Microsoft.EntityFrameworkCore;
using Practice.API.Entities;


namespace Practice.API.DbContexts
{
    public class InfoContext : DbContext
    {
        public DbSet<Users> User { get; set; }
        public InfoContext(DbContextOptions<InfoContext> options) : base(options)
        {

        }
    }
}
